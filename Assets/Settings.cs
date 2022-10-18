using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start() => SetDefault();
    
    private void SetDefault()
    {
        nameInput.text = PlayerPrefs.HasKey("Name") ?  PlayerPrefs.GetString("Name") : "";
        volumeSlider.value = PlayerPrefs.HasKey("Volume") ? PlayerPrefs.GetFloat("Volume") : 1;
        resolution.value = PlayerPrefs.HasKey("Resolution") ? PlayerPrefs.GetInt("Resolution") : 0;
    }
    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
        SetDefault();
    }
    
    public void SetVolumen() => PlayerPrefs.SetFloat("Volume", volumeSlider.value);
    public void SetName() => PlayerPrefs.SetString("Name", nameInput.text);
    public void SetResolution() =>  PlayerPrefs.SetInt("Resolution", resolution.value);
}
