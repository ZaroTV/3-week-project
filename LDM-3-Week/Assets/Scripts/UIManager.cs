using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameMenu;
    public Button openGameMenuButton;
    public Button exitGameButton;
    public bool gameMenuIsOpen;
   
    void Start()
    {
        gameMenu = GameObject.Find("GameMenu");
        openGameMenuButton = GameObject.Find("OpenGameMenuButton").GetComponent<Button>();
        openGameMenuButton.onClick.AddListener(OpenGameMenu);
        exitGameButton = GameObject.Find("ExitGameButton").GetComponent<Button>();
        exitGameButton.onClick.AddListener(ExitGame);
        gameMenu.SetActive(false);
    }
    void Update()
    {
        if (gameMenuIsOpen)
        {
            gameMenu.SetActive(true);
        }
        else
        {
            gameMenu.SetActive(false);
        }
    }
    void OpenGameMenu()
    {
        gameMenuIsOpen = !gameMenuIsOpen;
    }
    void ExitGame()
    {
        Application.Quit();
    }
}