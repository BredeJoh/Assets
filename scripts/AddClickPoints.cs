using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddClickPoints : MonoBehaviour {

    Text addclickGainText;
    float cost = 10f;
    float pointsAdded = 0f;
    float PointsAddNext = 1f;

    // Use this for initialization
    void Start () {
        addclickGainText = GameObject.Find("addText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Points.points >= cost)
        {
            Points.points -= cost;
            pointsAdded = PointsAddNext;
            Points.clickGain += pointsAdded;
            PointsAddNext *= 2f;
            cost *= 3f;
        }
	    addclickGainText.text = "Cost: " + cost + "\n+" + PointsAddNext + " per click";
        gameObject.SetActive(false);

    }
}
