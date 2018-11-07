using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody rb;
    public float thrust;
    public GameObject bulet;
    public GameObject spawnpoint;
    [Space]
    [Header("partical system")]
    public GameObject down1;
    public GameObject down2;
    public GameObject right;
    public GameObject left;
    //public Animator anim;
    void Start () {
        rb = GetComponent<Rigidbody>();       
        down1.SetActive(false);
        down2.SetActive(false);
        right.SetActive(false);
        left.SetActive(false);

    }


    void Update () {
        if (Input.GetButton("Vertical"))
        {
            rb.AddForce(transform.up * thrust);
            
            down1.SetActive(true);
            down2.SetActive(true);

        }
        if (Input.GetButtonUp("Vertical"))
        {

            down1.SetActive(false);
            down2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            right.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            left.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            right.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            left.SetActive(false);
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
