using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public GameObject trap1;
    public GameObject trap2;
    private int rand;
    private int num1 = 0;
    private int num2 = 0;
   /// <summary>
   /// this script randomly spawns extra obsticals
   /// </summary>
    void Start () {
        InvokeRepeating("Choose", 10, Random.Range(10, 15));
		
	}
	
	/// <summary>
    /// this randomly  chooses a object to spawn
    /// </summary>
    void Choose()
    {
       rand= Random.Range(1, 4);
      
        if (rand <= 2)
        {
        Spawn1();
            

        }
       if (rand > 2)
        {
            Spawn2();
            
        }
    }
    /// <summary>
    /// this part spawns obstical 1 if chosen
    /// </summary>
    void Spawn1()
    {
        if (num1<3)
        {
        Instantiate(trap1,new Vector3 (0,0,0), Quaternion.identity);
            num1 += 1;   
        }
        
    }
    /// <summary>
    /// this part spawns obstical 2 if chosen
    /// </summary>
    void Spawn2()
    {
        if (num2 < 2)
        {
            Instantiate(trap2, new Vector3(0, 0, 0), Quaternion.identity);
            num2 += 1;
        }
        
    }
}
