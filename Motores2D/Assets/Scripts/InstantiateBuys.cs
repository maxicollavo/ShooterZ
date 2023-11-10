using System;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBuys : MonoBehaviour
{
    public GameObject leftBuy;
    public GameObject rightBuy;
    private Pool<GameObject> poolRight;
    private Pool<GameObject> poolLeft;


    private List<GameObject> rightObjects = new List<GameObject>();
    private List<GameObject> leftObjects = new List<GameObject>();

    public Shop shop;

    private void Start()
    {
        poolRight = new Pool<GameObject>(CreateRight, (gameObject) => gameObject.SetActive(true), (gameObject) => gameObject.SetActive(false), 5);
        poolLeft = new Pool<GameObject>(CreateLeft, (gameObject) => gameObject.SetActive(true), (gameObject) => gameObject.SetActive(false), 5);
        EventManager.Instance.Register(GameEventTypes.BallScore, OnBallScore);
    }

    private void OnBallScore(object sender, EventArgs e)
    {
        rightObjects.ForEach((gameObject) => poolRight.ReturnObject(gameObject));
        leftObjects.ForEach((gameObject) => poolLeft.ReturnObject(gameObject));
        rightObjects.Clear();
        leftObjects.Clear();
    }

    private GameObject CreateRight()
    {
        return Instantiate(rightBuy);
    }

    private GameObject CreateLeft()
    {
        return Instantiate(leftBuy);
    }

    void OnMouseOver()
    {
        /*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = 10;

            InstantiateBuy(touchPosition);
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPosition.z = 10;

            InstantiateBuy(clickPosition);
        }
    }
    

    private void InstantiateBuy(Vector3 position)
    {
        if (shop.Active)
        {
            if (shop.rightBuys)
            {
                GameObject rightInstance = poolRight.GetObject();
                rightInstance.transform.position = position;
                rightInstance.transform.rotation = rightBuy.transform.rotation;
                rightObjects.Add(rightInstance);
            }
            else if (shop.leftBuys)
            {
                GameObject leftInstance = poolLeft.GetObject();
                leftInstance.transform.position = position;
                leftInstance.transform.rotation = leftBuy.transform.rotation;
                leftObjects.Add(leftInstance);
            }
        }
    }

}
