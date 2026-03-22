/*
    Ian Morgado Villaseñor (A01754495)
*/

using UnityEngine;

public class EstadoGoomba : MonoBehaviour
{
    public bool tocaPared {get; private set;} = false; // Es la forma de C# de definir los métodos getter y setter

    void OnTriggerEnter2D(Collider2D collision)
    {
        tocaPared = true;
        //print(tocaPared);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        tocaPared = false;
        //print(tocaPared);
    }
}
