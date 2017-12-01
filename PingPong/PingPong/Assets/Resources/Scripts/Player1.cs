using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print((Input.mousePosition.x / Screen.width * 16) - 8);
        print((Input.mousePosition.y / Screen.height * 16)-8);
        //print(Input.mousePosition.z);

        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 12) - 8;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePosInUnits,
                                                this.transform.position.z);

        //newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -3.5f, 3.5f);

        this.transform.position = newPaddlePos;

    }
}
