using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 16) - 6;

        Vector3 newPlayerPos = new Vector3(this.transform.position.x, mousePosInUnits,
                                                this.transform.position.z);

        newPlayerPos.y = Mathf.Clamp(mousePosInUnits, -4.33f, 4.33f);

        this.transform.position = newPlayerPos;
    }
}
