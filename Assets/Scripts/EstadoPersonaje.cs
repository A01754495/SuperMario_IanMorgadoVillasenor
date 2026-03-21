using Unity.VisualScripting;
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    public bool estaEnPiso {get; private set;} = false; // Es la forma de C# de definir los métodos getter y setter
    //public bool vivo {get; private set;} = true;

    void OnTriggerEnter2D(Collider2D collision)
    {
        // Pruebas que hacía para entender las tags
        // if (collision.CompareTag("Goomba"))
        // {
        //     print("Pisando Goomba!");
        //     vivo = false;
        // }
        // else
        // {
        //     estaEnPiso = true;   
        // }

        estaEnPiso = true; 
        //print(estaEnPiso);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
        //print(estaEnPiso);
    }
}
