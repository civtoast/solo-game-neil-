using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public AudioSource audioData;
    /// <summary>
    /// this script randomly moves the enemy
    /// </summary>
    void Start()
    {
        InvokeRepeating("Sound", 10, Random.Range(10, 30));
    }
    private void Sound()
    {
        audioData.Play(0);
        InvokeRepeating("Rotate", 2,2);
    }

    private void Rotate()
    {
        transform.Rotate(0, Random.Range(90, 180), 0);
        

    }

}
