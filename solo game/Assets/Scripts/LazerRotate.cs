using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerRotate : MonoBehaviour
{
    public float movespeed = 0.5f;
    // Use this for initialization
    void Start()
    {
        movespeed *= Mathf.Sign(Random.Range(-1f, 1f));


    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, movespeed, 0);
    }
}
