using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazerupanddown : MonoBehaviour {
    public float
        minRange = -2,
        maxRange = 2;
    /// <summary>
    ///  this script randomly moves the lazer up and down in the begining of the round
    /// </summary>
    void Start () {
        
        transform.Translate(transform.up*Random.Range(minRange, maxRange));
    }
	
	
}
