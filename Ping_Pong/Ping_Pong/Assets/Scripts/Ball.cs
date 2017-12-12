using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {
    LevelManager levelManager = new LevelManager();
    public static int score1 = 0;
    public static int score2 = 0;
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
        //score_01 = GetComponent<Text> ();
        //score_02 = GetComponent<Text>();

    }
    void Update()
    {
        if (!gameStarted)
        {
            this.transform.position = player2.transform.position + player2BallPosDiff;
        }
        if (Input.GetKeyDown("space") && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 10f);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 originalPos = new Vector3(0, 0, -5);
        string colName = collision.collider.name;
        if(colName == "Goal Post")
        {
            score2++;
            if(score2 >= 5)
            {
                levelManager.LoadNewScene("Level_02");
                score1 = 0;
                score2 = 0;            }
            this.transform.position = originalPos;
        }
        if(colName == "Goal Post2")
        {
            score1++;
            if (score1 >= 5)
            {
                levelManager.LoadNewScene("Level_02");
                score1 = 0;
                score2 = 0;
            }
            this.transform.position = originalPos;
        }
    }
}
