using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMannager : MonoBehaviour {
   /// <summary>
   /// this script takes the score and adds it to the text on the canvas
   /// </summary>

    public static ScoreMannager instance;
    private int timehit;
    public Text score;
    /// <summary>
    /// this part of the script makes it a singleton
    /// it tests to see if thear is a nother one of these scripts active and destroys it if is
    /// </summary>
    void Start () {

        InvokeRepeating("Timealive", 1, 1);
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
        
        timehit += 10;
        score.text = timehit.ToString();
    }
    public void Timealive()
    {
        timehit += 1;
        score.text = timehit.ToString();
    }

   
}
