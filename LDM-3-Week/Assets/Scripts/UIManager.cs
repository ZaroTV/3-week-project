using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : MonoBehaviour
{
    public GameObject gameMenu;
    public Button openGameMenuButton;
    public bool gameMenuIsOpen;
    void Start()
    {
        gameMenu = GameObject.Find("GameMenu");
        openGameMenuButton = GameObject.Find("OpenGameMenuButton").GetComponent<Button>();
        openGameMenuButton.onClick.AddListener(OpenGameMenu);
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
}