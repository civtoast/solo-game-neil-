using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public GameObject hitpoint;
    public float speed=-0.1f;
	void Start () {

        hitpoint = GameObject.Find("Hitpoint");
    }
	
	
	void Update () {

        transform.position += transform.forward*speed*Time.deltaTime;
       



    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
           
        
    }
    
}
