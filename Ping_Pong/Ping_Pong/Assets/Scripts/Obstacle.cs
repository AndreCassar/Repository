using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    string dir = "down";
    // Use this for initialization
    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        if (dir.Equals("down"))
        {
            if (position.y <= -4.33f)
            {
                dir = "up";

            }
            position.y = position.y - 0.05f;
            this.transform.position = position;
        }
        if (dir.Equals("up"))
        {
            if (position.y >= 4.33f)
            {
                dir = "down";

            }
            position.y = position.y + 0.05f;
            this.transform.position = position;
        }
    }
}
