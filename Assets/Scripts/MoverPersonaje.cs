using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPersonaje : MonoBehaviour
{
    [SerializeField]
    private InputAction accionMover;

    private float velocidadX = 5f;
    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void OnEnable()
    {
        accionMover.Enable();
        accionMover.performed += mover;
    }

    void OnDisable()
    {
        accionMover.Disable();
        accionMover.performed -= mover;
    }

    public void mover(InputAction.CallbackContext context)
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 movimiento = accionMover.ReadValue<Vector2>();
        rb.linearVelocityX = movimiento.x * velocidadX;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
