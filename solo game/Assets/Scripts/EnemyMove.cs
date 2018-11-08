using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    //public Animator anim;
    public int score;
    public ScoreMannager points;
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
            score += 10;
            points.Points();
            
        }
    }
}
