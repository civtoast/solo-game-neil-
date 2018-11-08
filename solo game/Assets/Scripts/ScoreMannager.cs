using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMannager : MonoBehaviour {

    public static ScoreMannager instance;
    public int score;
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

    }

   
}
