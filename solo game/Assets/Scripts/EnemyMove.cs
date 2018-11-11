using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
   
    /// <summary>
    /// this script randomly moves the enemy
    /// </summary>
    void Start()
    {
        InvokeRepeating("Rotate", 10, Random.Range(10, 30));
    }

    private void Rotate()
    {
       
        transform.Rotate(0, Random.Range(90, 180), 0);
        

    }

}
