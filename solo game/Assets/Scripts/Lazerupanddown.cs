using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazerupanddown : MonoBehaviour {
    public float
        minRange = -2,
        maxRange = 2;
    // Use this for initialization
    void Start () {
        // transform.Translate(0, Random.Range(10, 30), 0);
        transform.Translate(transform.up*Random.Range(minRange, maxRange));
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
