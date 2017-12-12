using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour {
    public Text score;

    // Use this for initialization
    void Start () {
        score.text = Ball.score1 + "";


    }
	
	// Update is called once per frame
	void Update () {
        score.text = Ball.score1 + "";
       // scoreIn2 = Ball.score2;
        //score2.text = scoreIn2 + "";
        //print(scoreIn);
    }
    /*public int getScore()
    {
        return scoreIn;
    }
    public void setScore(int score1)
    {
        
    }
    */
}
