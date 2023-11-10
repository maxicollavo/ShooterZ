using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store : MonoBehaviour
{
    [SerializeField]
    GameObject StoreGo;
    [SerializeField]
    GameObject MenuGo;

    public void StoreOn(){

        StoreGo.SetActive(true);
        MenuGo.SetActive(false);
    }

    public void StoreOff(){
        StoreGo.SetActive(false);
        MenuGo.SetActive(true);
    }
}
