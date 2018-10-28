using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody rb;
    public float thrust;
    public GameObject bulet;
    public GameObject spawnpoint;
    //public Animator anim;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	
	void Update () {
        if (Input.GetButton("Vertical"))
        {
            rb.AddForce(transform.up * thrust);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Playanimation
            Instantiate(bulet, spawnpoint.transform.position, spawnpoint.transform.rotation);

        }

	}

    public void Shoot()
    {
        Instantiate(bulet,spawnpoint.transform.position,spawnpoint.transform.rotation);
    }
}
