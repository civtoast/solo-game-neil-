using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //public Animator anim;
    private int health;
    void Start()
    {
        InvokeRepeating("Rotate", 10, Random.Range(10, 30));
    }

    private void Rotate()
    {
        //Playanimation
        transform.Rotate(0, Random.Range(90, 180), 0);
        //Playanimation

    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Bullet"))
        {
            //play hit animation
            health -= 10;
            print("Hit");
        }
    }
}
