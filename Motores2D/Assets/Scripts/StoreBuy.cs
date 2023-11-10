using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreBuy : MonoBehaviour
{
    bool one, two;
    [SerializeField]
    GameObject firstOption;
    [SerializeField]
    GameObject secondOption;

    void Start(){
        one = false;
        two = false;
    }

    public void BallOne(){
        if (!one)
        {
            Debug.Log("Compraste la primer opcion");
            one = true;
            var firstButton = firstOption.GetComponent<Button>();
            firstButton.interactable = false;
        }
    }

    public void BallTwo(){
        if (!two)
        {
            Debug.Log("Compraste la segunda opcion");
            two = true;
            var secondButton = secondOption.GetComponent<Button>();
            secondButton.interactable = false;
        }
    }
}
