using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class BotonRegresar : MonoBehaviour
{
    private UIDocument menu;
    private Button botonRegresar;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;

        botonRegresar = root.Q<Button>("BotonRegresar");

        botonRegresar.clicked += Regresar;
    }

    void OnDisable()
    {
        botonRegresar.clicked -= Regresar;
    }

    void Regresar()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
