/*
    Ian Morgado Villaseñor (A01754495)
*/

using System;
using UnityEngine;

public class CambiarAnimacion : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private EstadoPersonaje estado;
    private EstadoVivo vivo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        estado = GetComponentInChildren<EstadoPersonaje>();
        vivo = GetComponentInChildren<EstadoVivo>();
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetFloat("velocidad", MathF.Abs(rb.linearVelocityX));
        animator.SetFloat("velocidad", Math.Abs(rb.linearVelocityX));
        //animator.SetFloat("velocidadAbs", Math.Abs(rb.linearVelocityX));

        //print("Actualizando velocidad: ");
        //print((float)(rb.linearVelocityX));

        // Manejar el FLIP_x
        sr.flipX = (sr.flipX || rb.linearVelocityX < -0.1) && rb.linearVelocityX <= 0; // ni idea de pq funciona pero lo hace
        

        // Manejar animación de salto
        animator.SetBool("enPiso", estado.estaEnPiso);

        // Manejar animación de muerte
        animator.SetBool("vivo", vivo.estadoVivo);
    }
}