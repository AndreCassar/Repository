﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    int timesHit;
    LevelManager levelManager = new LevelManager();
    public int maxHit;
	// Use this for initialization
	void Start () {
		timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + ": " + timesHit);
        if(timesHit >= maxHit)
        {
            Destroy(gameObject);
        }
    }

    /*void testWin()
    {
        levelManager.LoadNextScene();
    }
    */
}