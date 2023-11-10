using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public bool Active { get; private set; }
    public bool rightBuys { get; private set; }
    public bool leftBuys { get; private set; }

    public GameObject buyIns;
    public GameObject ballIns;

    void Start()
    {
        Active = true;
        EventManager.Instance.Register(GameEventTypes.BallScore, OnBallScore);
    }

    private void OnBallScore(object sender, EventArgs e)
    {
        Reset();
    }

    public void Reset()
    {
        Active = true;
        buyIns.SetActive(true);
        ballIns.SetActive(false);
    }

    public void BuyRight()
    {
        rightBuys = true;
        leftBuys = false;
    }

    public void BuyLeft()
    {
        leftBuys = true;
        rightBuys = false;
    }

    public void ExitShop()
    {
        Active = false;
        buyIns.SetActive(false);
        ballIns.SetActive(true);
    }
}
