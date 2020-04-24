using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject youWinLoseBox;
    public Image youWinLoseImage;
    public Sprite winSprite;
    public Sprite loseSprite;
    public float winLoseTimer;
    public int underlingCounter;
    public bool win;
    public bool lose;
    public Vector3 scaleResize;
    void Start()
    {
        youWinLoseBox = GameObject.Find("YouWinBox");
        youWinLoseImage = GameObject.Find("YouWinBox").GetComponent<Image>();
        scaleResize = new Vector3(0.01f, 0.01f, 0);
        youWinLoseBox.SetActive(false);
    }
    void Update()
    {
        Win();
        Lose();
    }
    public void Win()
    {
        if (win)
        {
            youWinLoseBox.SetActive(true);
            youWinLoseImage.sprite = winSprite;
            winLoseTimer -= Time.deltaTime;
            if (winLoseTimer >= 1)
            {
                youWinLoseBox.transform.localScale += scaleResize;
                if (youWinLoseBox.transform.localScale.x >= 1 && youWinLoseBox.transform.localScale.y >= 1)
                {
                    youWinLoseBox.transform.localScale = new Vector3(1, 1, 0);
                }
            }
            if (winLoseTimer < 0.5f)
            {
                youWinLoseBox.transform.localScale -= scaleResize;
                if (youWinLoseBox.transform.localScale.x <= 0 && youWinLoseBox.transform.localScale.y <= 0)
                {
                    youWinLoseBox.transform.localScale = new Vector3(0.01f, 0.01f, 0);
                }
            }

            if (winLoseTimer <= 0)
            {
                winLoseTimer = 5;
                youWinLoseBox.transform.localScale = new Vector3(0.01f, 0.01f, 0f);
                youWinLoseBox.SetActive(false);
                win = false;
            }
        }
    }
    public void Lose()
    {
        if (lose)
        {
            youWinLoseBox.SetActive(true);
            youWinLoseImage.sprite = loseSprite;
            winLoseTimer -= Time.deltaTime;
            if (winLoseTimer >= 1)
            {
                youWinLoseBox.transform.localScale += scaleResize;
                if (youWinLoseBox.transform.localScale.x >= 1 && youWinLoseBox.transform.localScale.y >= 1)
                {
                    youWinLoseBox.transform.localScale = new Vector3(1, 1, 0);
                }
            }
            if (winLoseTimer < 0.5f)
            {
                youWinLoseBox.transform.localScale -= scaleResize;
                if (youWinLoseBox.transform.localScale.x <= 0 && youWinLoseBox.transform.localScale.y <= 0)
                {
                    youWinLoseBox.transform.localScale = new Vector3(0.01f, 0.01f, 0);
                }
            }

            if (winLoseTimer <= 0)
            {
                winLoseTimer = 5;
                youWinLoseBox.transform.localScale = new Vector3(0.01f, 0.01f, 0f);
                youWinLoseBox.SetActive(false);
                lose = false;
            }
        }
    }
}