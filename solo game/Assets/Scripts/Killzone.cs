using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killzone : MonoBehaviour {
    int hit = 0 ;
    
/// <summary>
/// this script opens the Gameover menu and kills the player
/// </summary>

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (hit<3)
            {
                //fadecharacter
            }
            else if (hit>3)
            {
            SceneManager.LoadScene("Gameover");

            }
        }
    }
   
}
