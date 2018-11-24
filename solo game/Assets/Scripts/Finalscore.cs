using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finalscore : MonoBehaviour {
    public Text final; 
    static int score=0;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);

		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        final.text = score.ToString(); 
        score = ScoreMannager.finalscore;
        print(score);
    }
}
