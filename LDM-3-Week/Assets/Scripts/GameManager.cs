using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject youWinLoseBox;
    public GameObject magmaEffectWin;
    public GameObject magmaEffectLose;
    public Image youWinLoseImage;
    public Sprite winSprite;
    public Sprite loseSprite;
    public float winLoseTimer;
    public int underlingCounter;
    public bool showResult;
    public bool win;
    public bool winMagmaEffect;
    public bool loseMagmaEffect;
    public Vector3 scaleResize;
    void Start()
    {
        youWinLoseBox = GameObject.Find("YouWinBox");
        youWinLoseImage = GameObject.Find("YouWinBox").GetComponent<Image>();
        scaleResize = new Vector3(0.01f, 0.01f, 0);
        winLoseTimer = 5f;
        youWinLoseBox.SetActive(false);
    }
    void Update()
    {
        if(showResult)
        {
            Result();
        }
    }
    public void Result()
    {
        youWinLoseBox.SetActive(true);
        if (win)
        {
            youWinLoseImage.sprite = winSprite;
        }
        else
        {
            youWinLoseImage.sprite = loseSprite;
        }
        if (winMagmaEffect)
        {
            Instantiate(magmaEffectWin, new Vector3(63.9f, 19f, 38.75f), Quaternion.identity);
            winMagmaEffect = false;
        }
        if (loseMagmaEffect)
        {
            Instantiate(magmaEffectLose, new Vector3(63.9f, 19f, 38.75f), Quaternion.identity);
            loseMagmaEffect = false;
        }
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
            showResult = false;
            winLoseTimer = 5;
            youWinLoseBox.transform.localScale = new Vector3(0.01f, 0.01f, 0f);
            youWinLoseBox.SetActive(false);
        }
    }
}