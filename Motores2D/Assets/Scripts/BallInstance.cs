using System;
using UnityEngine;

public class BallInstance : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject ballIns;
    public Shop shop;

    protected bool ball { get; private set; }

    private void Start()
    {
        this.gameObject.SetActive(false);
        EventManager.Instance.Register(GameEventTypes.BallScore, OnBallScore);
    }

    private void OnBallScore(object sender, EventArgs e)
    {
        Reset();
    }

    private void Reset()
    {
        ball = false;
        Destroy(ballIns);
    }

    void OnMouseOver()
    {
        /*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 10;

            InstantiateBall(touchPosition);
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 10;

            InstantiateBall(clickPosition);
            ball = true;
        }
    }

    private void InstantiateBall(Vector3 position)
    {
        if (!shop.Active)
        {
            if (!ball)
            {
                ballIns = Instantiate(ballPrefab, position, Quaternion.identity);
                Debug.Log("InsBall");
            }
        }
    }
}
