using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour
{
    public InputField sizeInput;
    public string nameValue;
    public delegate void OnChangeSize();
    public static event OnChangeSize changed;

    public void Awake()
    {
        sizeInput.onValueChanged.AddListener(delegate { onChange(); });
    }
    public void onChange()
    {
        nameValue = sizeInput.text;
        changed();
    }

}
