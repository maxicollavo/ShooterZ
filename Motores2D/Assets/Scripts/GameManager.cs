using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject shop;
    [SerializeField]
    GameObject MenuGoImg;
    GameObject lastLevelLoaded;
    public int currentLevel = 0;
    public List<GameObject> levels = new List<GameObject>();

    private void Start()
    {
        EventManager.Instance.Register(GameEventTypes.BallScore, OnBallScore);
    }

    private void OnBallScore(object sender, EventArgs e)
    {
        currentLevel++;
        LoadLevel();
    }

    public void LoadLevel()
    {
        if (lastLevelLoaded != null) Destroy(lastLevelLoaded);
        lastLevelLoaded = Instantiate(levels[currentLevel]);
        shop.SetActive(true);
        MenuGoImg.SetActive(false);
    }

    public void StartGame()
    {
        currentLevel = 1;
    }
    public void LoadMenuGo()
    {
        shop.SetActive(false);
        MenuGoImg.SetActive(true);
        currentLevel = 0;
    }
}
