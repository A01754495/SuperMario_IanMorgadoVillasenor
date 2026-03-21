using UnityEngine;

public class EstadoVivo : MonoBehaviour
{
    public bool estadoVivo {get; private set;} = true; // Es la forma de C# de definir los métodos getter y setter

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("lateralGoomba"))
        {
            print("Tocaste a un Goomba!");
            estadoVivo = false;
            print(estadoVivo);
        }
    }

    // void OnTriggerExit2D(Collider2D collision)
    // {
    // }
}
