using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static float points = 0f;
    public static float clickGain = 1f;
    float multiplier = 1f;
    Text pointsText;
    

    // Use this for initialization
    void Start () {
        pointsText = GameObject.Find("PointsInfo").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        pointsText.text = "Points: " + Points.points + "\nPoints per click: " + clickGain;
        clickGain = clickGain * multiplier;
        
	}
}
