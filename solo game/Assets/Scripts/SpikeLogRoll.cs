﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLogRoll : MonoBehaviour {
    public float rollspeed = -0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        transform.Rotate(0, rollspeed, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SpikeLog"))
        {
            rollspeed *= -1;
        }
    }
}