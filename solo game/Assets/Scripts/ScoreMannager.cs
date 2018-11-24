using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreMannager : MonoBehaviour {
   /// <summary>
   /// this script takes the score and adds it to the text on the canvas
   /// </summary>

    public static ScoreMannager instance;
    private int timehit;
    public Text score;
    public static int finalscore;
    Scene currentScene;
    string sceneName;
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
        
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        DontDestroyOnLoad(gameObject);
        
    }

    /// <summary>
    /// this updates the points by testing for hit and seconds alive
    /// </summary>

    public void Points()
    {
        if (score!=null)
        {

        timehit += 10;
        score.text = timehit.ToString();
        }

    }
    public void Timealive()
    {
        if (score!=null)
        {
        timehit += 1;
        score.text = timehit.ToString();

        }
    }
    private void LateUpdate()
    {

        finalscore = timehit;
      
    }

}
