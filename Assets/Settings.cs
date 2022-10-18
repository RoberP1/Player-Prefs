using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start()
    {
       
    }

    public void SetVolumen()
    {
        // Guardar los datos del volumen.
    }

    public void SetName()
    {
        // Guardar los datos del nombre.
    }

    public void SetResolution()
    {
        // Guardar los datos de la resolucion.
    }

    public void ResetDefault()
    {
        // Borrar todos los datos existentes.
    }
}
