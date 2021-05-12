using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    Canvas mainCanvas;
    [SerializeField]
    GameObject optionsPanel;

    public Button StartButton;
    public Button OptionsButton;
    public Button QuitButton;

    private void Awake()
    {
        StartButton.onClick.AddListener(StartGame);
        OptionsButton.onClick.AddListener(Options);
        QuitButton.onClick.AddListener(Quit);
    }
    public void StartGame()
    {
        mainCanvas.gameObject.SetActive(false);
        //make the sheep active
        //and a button
    }

    public void Options()
    {
        optionsPanel.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
