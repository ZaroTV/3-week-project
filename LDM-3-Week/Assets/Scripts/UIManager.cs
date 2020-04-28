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
    public GameObject battleMenu;
    public Button cancelAttack;
    public Button easyBase;
    public Button normalBase;
    public Button hardBase;
    public float cancelAttackTimer;
    public bool hasCanceledAttack;
    public bool returnSummoningHall;

    void Start()
    {
        gameMenu = GameObject.Find("GameMenu");
        openGameMenuButton = GameObject.Find("OpenGameMenuButton").GetComponent<Button>();
        openGameMenuButton.onClick.AddListener(OpenGameMenu);
        exitGameButton = GameObject.Find("ExitGameButton").GetComponent<Button>();
        exitGameButton.onClick.AddListener(ExitGame);
        battleMenu = GameObject.Find("BattleMenu");
        cancelAttack = GameObject.Find("CancelButton").GetComponent<Button>();
        cancelAttack.onClick.AddListener(CancelAttack);
        gameMenu.SetActive(false);
        battleMenu.SetActive(false);
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
        if (hasCanceledAttack)
        {
            cancelAttackTimer -= Time.deltaTime;
            if (cancelAttackTimer <= 0)
            {
                returnSummoningHall = false;
                hasCanceledAttack = false;
                cancelAttackTimer = 5;
            }
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

    void CancelAttack()
    {
        hasCanceledAttack = true;
        returnSummoningHall = true;
    }
}