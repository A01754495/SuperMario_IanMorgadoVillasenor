//using UnityEditor.Callbacks;
using UnityEngine;
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

    // Update is called once per frame
    void Update()
    {
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }
}
