using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMannager : MonoBehaviour {
   /// <summary>
   /// this script takes the score and adds it to the text on the canvas
   /// </summary>

    public static HealthMannager instance;
    private int timehit;
    public Slider health;
    int healthpoints=100;
    /// <summary>
    /// this part of the script makes it a singleton
    /// it tests to see if thear is a nother one of these scripts active and destroys it if is
    /// </summary>
    void Start () {

        
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// this updates the points by testing for hit and seconds alive
    /// </summary>

    public void Points()
    {
        
        healthpoints -= Random.Range(5,15);
        health.value = healthpoints;
    }
   

   
}
