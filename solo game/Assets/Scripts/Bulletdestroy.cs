using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdestroy : MonoBehaviour {

	/// <summary>
    /// this script destroys the bullet when it exits a trigger
    /// </summary>
    
	

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Bullet"))
        {
            
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {

            Destroy(collision.gameObject);
        }
    }


}
