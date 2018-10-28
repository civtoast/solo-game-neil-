using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthMannager : MonoBehaviour {

    public static HealthMannager instance;
    
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
   
}
