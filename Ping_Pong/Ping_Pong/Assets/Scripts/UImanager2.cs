using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager2 : MonoBehaviour {
    public Text score2;
    // Use this for initialization
    void Start () {
        score2.text = Ball.score2 + "";
		
	}
	
	// Update is called once per frame
	void Update () {
        score2.text = Ball.score2 + "";

    }
}
