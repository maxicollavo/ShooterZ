using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs_LevelOne : MonoBehaviour
{
    Animator anim;
    public float speed;

    private void Start()
    {
        anim = GetComponent<Animator>();
        speed = 0.5f;
    }

    private void Update()
    {
        anim.speed = speed;
    }
}
