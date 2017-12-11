using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {

    public Text score;
    public static int scoreIn = 0;

	// Use this for initialization
	void Start () {
        score.text = scoreIn + "";
		

    }
	
	// Update is called once per frame
	void Update () {
        score.text = scoreIn + "";
    }
    public int getScore()
    {
        return scoreIn;
    }
    public void setScore(int score1)
    {
        scoreIn = score1;
    }
}
