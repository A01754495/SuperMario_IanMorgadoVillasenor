using System.Reflection.Emit;
using UnityEngine;

public class MoverGoomba : MonoBehaviour
{
    private Rigidbody2D rb;
    private EstadoGoomba estado;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocityX = 1;
        estado = GetComponentInChildren<EstadoGoomba>();
    }

    // Update is called once per frame
    void Update()
    {
        if (estado.tocaPared)
        {
            rb.linearVelocityX = rb.linearVelocityX * -1;
        }
        // else
        // {
        //     rb.linearVelocityX = rb.linearVelocityX;
        // }
    }
}
