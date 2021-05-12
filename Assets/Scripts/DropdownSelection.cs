using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownSelection : MonoBehaviour
{
    public string selection;
    public Dropdown dropdown;
    public int index;
    public delegate void OnChangeColor();
    public static event OnChangeColor changed;

    private void Awake()
    {
        dropdown.onValueChanged.AddListener(delegate {onChange(); });
    }

    public void onChange()
    {
        index = dropdown.value;
        selection = dropdown.captionText.text;
        changed();
    }
}
