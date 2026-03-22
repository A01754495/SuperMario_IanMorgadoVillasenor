using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    private UIDocument menu;
    private Button botonJugar;
    private Button botonAyuda;
    private Button botonCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonJugar = root.Q<Button>("BotonJugar");
        botonAyuda = root.Q<Button>("BotonAyuda");
        botonCreditos = root.Q<Button>("BotonCreditos");

        //Callbacks
        botonJugar.RegisterCallback<ClickEvent>(AbrirJugar);
    }

    private void AbrirJugar(ClickEvent evt)
    {
        SceneManager.LoadScene("PrimerPantalla");
    }

    private void AbrirAyuda(ClickEvent evt)
    {}

    private void AbrirCreditos(ClickEvent evt)
    {}
}
