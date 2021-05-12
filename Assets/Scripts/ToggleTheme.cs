using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleTheme : MonoBehaviour
{
    public Slider themeSlider;
    public bool on;
    public delegate void OnChangeTheme();
    public static event OnChangeTheme changed;

    // Use this for initialization
    void Start()
    {
        themeSlider.onValueChanged.AddListener(delegate { onChange(); });
    }

    public void onChange()
    {
       float value = themeSlider.value;
       on = (value == 1) ? true : false;
       changed();
    }
}
