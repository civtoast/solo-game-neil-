using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healthmanager1 : MonoBehaviour {
    public static Healthmanager1 instance;
    private int timehit;
    public Slider health;
    int healthpoints = 100;
    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        InvokeRepeating("Timealive", Random.Range(15,20), Random.Range(15, 20));
    }

    public void Update()
    {
        if (healthpoints==0)
        {
        SceneManager.LoadScene("Victory");

        }
    }
    public void Points()
    {

        healthpoints -= 1;
        health.value = healthpoints;
    }
    public void Timealive()
    {
        healthpoints += 10;
        health.value = healthpoints;
    }

}
