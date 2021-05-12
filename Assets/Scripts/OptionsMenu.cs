using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OptionsMenu : MonoBehaviour
{
    public InputText sizeFont;
    public DropdownSelection textColor;
    public ToggleTheme theme;
    public VolumeValue volumeOptions;
    public GameObject light;
    public GameObject dark;
    Text[] texts;
    public Button doneButton;
    public AudioSource backgroundAudio;

    private void Start()
    {
        texts = FindObjectsOfType<Text>();
        DropdownSelection.changed += ChangeColor;
        InputText.changed += ChangeSize;
        ToggleTheme.changed += ChangeTheme;
        VolumeValue.changed += ChangeVolume;
        doneButton.onClick.AddListener(Done);
    }

    public void ChangeSize()
    {
        foreach (Text text in texts)
        {
            text.fontSize = Convert.ToInt16(sizeFont.nameValue);
        }
    }

    public void ChangeColor()
    {
        switch (textColor.index)
        {
            case 0:
                foreach (Text text in texts)
                {
                    text.color = new Color(255, 255, 255);
                }
                break;
            case 1:
                foreach (Text text in texts)
                {
                    text.color = new Color(0, 0, 0);
                }
                break;
            case 2:
                foreach (Text text in texts)
                {
                    text.color = new Color(0, 255, 0);
                }
                break;
            default:
                break;
        }

    }

    private void Done()
    {
        this.gameObject.SetActive(false);
    }

    private void ChangeTheme()
    {
        if (theme.on)
        {
            dark.SetActive(true);
            light.SetActive(false);
        }
        else
        {
            dark.SetActive(false);
            light.SetActive(true);
        }
    }

    private void ChangeVolume()
    {
        backgroundAudio.volume = volumeOptions.volume;
    }
}



namespace UnityEngine
{
    public static class Extensions
    {
        public static T GetChildComponentByTag<T>(this GameObject obj, string tag) where T : Component
        {
            foreach (T child in obj.GetComponentsInChildren<T>())
            {
                if (child.CompareTag(tag))
                {
                    return child;
                }
            }
            return null;
        }

        public static T GetChildComponentByName<T>(this GameObject obj, string name) where T : Component
        {
            foreach (T child in obj.GetComponentsInChildren<T>())
            {
                if (child.name == name)
                {
                    return child;
                }
            }
            return null;
        }
    }

}