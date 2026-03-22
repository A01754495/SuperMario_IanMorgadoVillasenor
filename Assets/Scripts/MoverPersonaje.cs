/*
    Ian Morgado Villaseñor (A01754495)
*/

//using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover;

    [SerializeField]
    private InputAction accionSaltar;

    private float velocidadX = 5f;
    private float velocidadY = 7.5f;
    private Rigidbody2D rb;
    private float timerMuerte = 0.0f;

    //private EstadoPersonaje estado;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        accionMover.Enable();
        rb = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        accionSaltar.Enable();
        accionSaltar.performed += saltar;
    }

    void OnDisable()
    {
        accionSaltar.Disable();
        accionSaltar.performed -= saltar;
    }

    public void saltar(InputAction.CallbackContext context)
    {
        EstadoPersonaje estado = GetComponentInChildren<EstadoPersonaje>();
        float salto = accionSaltar.ReadValue<float>();
        if (estado.estaEnPiso)
        {
            rb.linearVelocityY = salto * velocidadY;
        }
    }

    // Función para manejar la muerte
    private void morir()
    {
        EstadoVivo vivo = GetComponentInChildren<EstadoVivo>();
        Collider2D collider = GetComponent<Collider2D>();
        //SpriteRenderer sr = GetComponent<SpriteRenderer>();

        // Desactiva movimiento y collider si detecta que Mario muere
        if (!(vivo.estadoVivo))
        {
            OnDisable();
            rb.linearVelocityX = 0;
            collider.enabled = false;

            // Timer para aventarlo a arriba
            timerMuerte += Time.deltaTime;

            // Lo avienta hacia arriba para simular la animación de muerte original
            if (timerMuerte < 0.3f)
            {
                rb.linearVelocityY = 3;
            }

            if (timerMuerte > 2.0f)
            {
                SceneManager.LoadScene("MenuInicial");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        morir();
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }
}
