using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScores : MonoBehaviour {
    public Text finalScore;
    public Text finalScore2;
    public Text winner;
    string w;
    // Use this for initialization
    void Start () {
        if (Ball.finalScore1 < Ball.finalScore2)
        {
            w = "Player 2 wins !!!";
        }
        else
        {
            w = "Player 1 wins !!!";
        }
        finalScore.text = "Player 1: " + Ball.finalScore1 + "";
        finalScore2.text = "Player 2: " + Ball.finalScore2 + "";
        winner.text = w;
    }
	
	// Update is called once per frame
	void Update () {
        //finalScore.text = Ball.score1 + "";
        //finalScore2.text = Ball.score1 + "";
    }
}
