using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumenSlider : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image ImageMute;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }
    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();

    }

    public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            ImageMute.enabled = true;
        }
        else
        {
            ImageMute.enabled = false;
        }
    }

}
