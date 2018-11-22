using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeLogRoll : MonoBehaviour {
    public float rollspeed = 0;
    private float rand=0;
    /// <summary>
    /// this script rotates the spike log
    /// </summary>
    private void Start()
    {
        rand = Mathf.Sign(Random.Range(-0.5f, 0.5f));
        if (rand==1)
        {
            rollspeed = 0.5f;
        }
        else if (rand==-1)
        {
            rollspeed = -0.5f;
        }
    }
    void Update () {


        transform.Rotate(0, rollspeed, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SpikeLog"))
        {
            rollspeed *= -1;
        }
    }
}
