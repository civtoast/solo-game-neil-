using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMannager : MonoBehaviour {
   

    public static ScoreMannager instance;
    private int timehit;
    public Text score;
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
	
	
	void Update () {
		
	}
    public void Points()
    {
        print("Hit");
        timehit += 10;
        score.text = timehit.ToString();
    }

   
}
