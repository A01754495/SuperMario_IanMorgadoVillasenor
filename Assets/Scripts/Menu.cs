/*
    Ian Morgado Villaseñor (A01754495)
*/

using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private VisualElement botones;
    private VisualElement menuAyuda;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;
    private Button volverBotones;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonJugar = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");
        volverBotones = root.Q<Button>("VolverBotones");

        botones = root.Q<VisualElement>("Botones");
        menuAyuda = root.Q<VisualElement>("MenuAyuda");

        botonJugar.clicked += AbrirJugar;
        botonAyuda.clicked += AbrirAyuda;
        botonCreditos.clicked += AbrirCreditos;
        volverBotones.clicked += VolverBotones;
    }

    void OnDisable()
    {
        botonJugar.clicked -= AbrirJugar;
        botonAyuda.clicked -= AbrirAyuda;
        botonCreditos.clicked -= AbrirCreditos;
        volverBotones.clicked -= VolverBotones;
    }

    private void AbrirJugar()
    {
        SceneManager.LoadScene("PrimerPantalla");
    }

    private void AbrirAyuda()
    {
        botones.style.display = DisplayStyle.None;
        menuAyuda.style.display = DisplayStyle.Flex;
    }

    private void AbrirCreditos()
    {
        //SceneManager.LoadScene("PrimerPantalla");
    }

    private void VolverBotones()
    {
        menuAyuda.style.display = DisplayStyle.None;
        botones.style.display = DisplayStyle.Flex;
    }
}
