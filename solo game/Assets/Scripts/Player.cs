using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Rigidbody rb;
    public float thrust;
    public GameObject bulet;
    public GameObject spawnpoint;
    /// <summary>
    /// these varables get the thruster particals
    /// </summary>
    [Space]
    [Header("partical system")]
    public GameObject down1;
    public GameObject down2;
    public GameObject right;
    public GameObject left;
    
    /// <summary>
    /// this sets all the  particals to be inactive when you dont press anything
    /// </summary>
    void Start () {
        rb = GetComponent<Rigidbody>();       
        down1.SetActive(false);
        down2.SetActive(false);
        right.SetActive(false);
        left.SetActive(false);

    }


    void Update () {
        /// <summary>
        /// this gets up input to move the player up and play the up  thruster particals 
        /// </summary>
        if (Input.GetButton("Vertical"))
        {
            rb.AddForce(transform.up * thrust);
            
            down1.SetActive(true);
            down2.SetActive(true);

        }
        /// <summary>
        /// this disables the particals 
        /// </summary>
        if (Input.GetButtonUp("Vertical"))
        {

            down1.SetActive(false);
            down2.SetActive(false);
        }
        /// <summary>
        /// these eable left and right boosters
        /// </summary>
        if (Input.GetKey(KeyCode.A))
        {
            right.SetActive(true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            left.SetActive(true);
        }
        /// <summary>
        /// tese diable left and right boosters
        /// </summary>
        if (Input.GetKeyUp(KeyCode.A))
        {
            right.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            left.SetActive(false);
        }
        /// <summary>
        /// this spawns the bulet prefab
        /// </summary>
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Instantiate(bulet, spawnpoint.transform.position, spawnpoint.transform.rotation);

        }

	}

    public void Shoot()
    {
        Instantiate(bulet,spawnpoint.transform.position, Quaternion.identity);
    }
}
