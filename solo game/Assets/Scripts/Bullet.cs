using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    /// <summary>
    /// This script makes the bulet prefab move forward 
    /// </summary>
    
    public float speed=-0.1f;
	void Start () {

        
    }
	
	
	void Update () {
        /// <summary>
        /// this code moves the bullet
        /// </summary>
        transform.position += transform.forward*speed*Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        /// <summary>
        /// this line of code destroys the bullet when it collides with A object
        /// </summary>  
        Destroy(this.gameObject);

        
    }
    
}
