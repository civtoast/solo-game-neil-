using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerturn : MonoBehaviour {
    public float rotationSpeed; 
    /// <summary>
    /// this script gets the left and right inputs and moves the player around the squid
    /// </summary>
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed* Time.deltaTime;
        transform.Rotate(0, rotation, 0);


    }
}
