using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeValue : MonoBehaviour
{
    public Slider volumeSlider;
    public float volume;

    public delegate void OnChangedVolume();
    public static event OnChangedVolume changed;

    private void Start()
    {
        volumeSlider.value = 1;
        volumeSlider.onValueChanged.AddListener(delegate { onChange(); });
    }

    public void onChange()
    {
        volume = volumeSlider.value;
        changed();
    }
}
