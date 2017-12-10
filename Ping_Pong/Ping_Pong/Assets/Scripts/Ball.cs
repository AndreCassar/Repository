using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Player1 player;
    Player2 player2;
    Vector3 player2BallPosDiff;
    bool gameStarted = false;


    // Use this for initialization
    void Start()
    {
        player = GameObject.FindObjectOfType<Player1>();
        player2 = GameObject.FindObjectOfType<Player2>();
        player2BallPosDiff = this.transform.position - player2.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (!gameStarted)
        {
            this.transform.position = player2.transform.position + player2BallPosDiff;
        }

        if (Input.GetKeyDown("space") && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

    }
}
