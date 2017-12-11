using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 position = this.transform.position;
            if (position.y < 4.33f)
            {
                position.y = position.y + 0.33f;
                this.transform.position = position;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 position = this.transform.position;
            if(position.y > -4.33f)
            { 
                position.y = position.y - 0.33f;
                this.transform.position = position;
            }
        }
    }
}

