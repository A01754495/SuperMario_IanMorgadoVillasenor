using Unity.VisualScripting;
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    public bool estaEnPiso {get; private set;} = false; // Es la forma de C# de definir los métodos getter y setter

    void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
        print(estaEnPiso);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
        print(estaEnPiso);
    }
}
