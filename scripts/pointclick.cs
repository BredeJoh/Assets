using UnityEngine;
using System.Collections;

public class pointclick : MonoBehaviour {

    

    // Use this for initialization
    void Start()
    {
        
    }
	// Update is called once per frame
	void Update ()
    {
        addPoints();       
    }
    void addPoints()
    {
        Points.points += Points.clickGain;
        gameObject.SetActive(false);
    }
}

