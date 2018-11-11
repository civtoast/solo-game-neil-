using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyscore : MonoBehaviour {
    /// <summary>
    /// these varables get the score Manager and keeps track of score
    /// </summary>
    public ScoreMannager points;
    private int score;
    public Animator anim;

   
    
    private void OnTriggerEnter(Collider other)
    {
        /// <summary>
        /// this keeps track of score
        /// </summary>

        if (other.CompareTag("Bullet"))
        {
           
            score += 10;
            points.Points();
            
        }
    }
}
