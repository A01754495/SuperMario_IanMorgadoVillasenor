/*
    Ian Morgado Villaseñor (A01754495)
*/

using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using System;
//using TextElement = UnityEngine.UIElements.TextElement;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private VisualElement titulo;
    private VisualElement botones;
    private VisualElement autor;
    private VisualElement menuAyuda;
    private VisualElement menuCreditos;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;
    private Button volverBotones;   
    private Button salirCreditos;
    private Label creditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonJugar = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");
        volverBotones = root.Q<Button>("VolverBotones");
        salirCreditos = root.Q<Button>("SalirCreditos");

        creditos = root.Q<Label>("Creditos");

        titulo = root.Q<VisualElement>("Titulo");
        botones = root.Q<VisualElement>("Botones");
        autor = root.Q<VisualElement>("Autor");
        menuAyuda = root.Q<VisualElement>("MenuAyuda");
        menuCreditos = root.Q<VisualElement>("MenuCreditos");

        botonJugar.clicked += AbrirJugar;
        botonAyuda.clicked += AbrirAyuda;
        botonCreditos.clicked += AbrirCreditos;
        volverBotones.clicked += VolverBotones;
        salirCreditos.clicked += VolverMenu;
    }

    void OnDisable()
    {
        botonJugar.clicked -= AbrirJugar;
        botonAyuda.clicked -= AbrirAyuda;
        botonCreditos.clicked -= AbrirCreditos;
        volverBotones.clicked -= VolverBotones;
        salirCreditos.clicked -= VolverMenu;
    }

    // Carga mapa
    private void AbrirJugar()
    {
        SceneManager.LoadScene("PrimerPantalla");
    }

    // Desactiva Display de los botones y activa el de la Ayuda
    private void AbrirAyuda()
    {
        botones.style.display = DisplayStyle.None;
        menuAyuda.style.display = DisplayStyle.Flex;
    }

    // Desactiva todos los VisualElements y activa los créditos
    private void AbrirCreditos()
    {
        titulo.style.display = DisplayStyle.None;
        botones.style.display = DisplayStyle.None;
        autor.style.display = DisplayStyle.None;
        menuCreditos.style.display = DisplayStyle.Flex;
    }

    // Desactiva Display de Ayuda y activa el de los botones
    private void VolverBotones()
    {
        menuAyuda.style.display = DisplayStyle.None;
        botones.style.display = DisplayStyle.Flex;
    }

    // Desactiva los créditos y reactiva los VisualElements del menu
    private void VolverMenu()
    {
        menuCreditos.style.display = DisplayStyle.None;
        titulo.style.display = DisplayStyle.Flex;
        botones.style.display = DisplayStyle.Flex;
        autor.style.display = DisplayStyle.Flex;
    }
}
