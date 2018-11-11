using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer2Rotate : MonoBehaviour {
    public float movespeed = 0.5f;
    
	
	/// <summary>
    /// this scrip makes the second Lazer rotate
    /// </summary>
	void Update () {
        transform.Rotate(0, movespeed, 0);
    }
}
