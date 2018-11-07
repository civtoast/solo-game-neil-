using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject trap1;
    public GameObject trap2;
    private int rand;
    private int num1 = 0;
    private int num2 = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        InvokeRepeating("Choose", 10, 15);
	}
    void Choose()
    {
        rand= Random.Range(1, 3);
        if (rand<=2)
        {
        Spawn1();

        }
       else if (rand > 2)
        {
            Spawn2();

        }
    }
    void Spawn1()
    {
        if (num1<3)
        {
        Instantiate(trap1,new Vector3 (0,0,0), Quaternion.identity);
            num1 += 1;   
        }
        
    }
    void Spawn2()
    {
        if (num2 < 2)
        {
            Instantiate(trap2, new Vector3(0, 0, 0), Quaternion.identity);
            num2 += 1;
        }
        
    }
}
