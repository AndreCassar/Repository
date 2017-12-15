using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNewScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void RestartGame()
    {
        Ball.finalScore1 = 0;
        Ball.finalScore2 = 0;
        Ball.finalScore2 = 0;
        Ball.maxScore = 6;
        SceneManager.LoadScene("Level_01");
    }
    public void LoadNextScene()
    {
        Ball.finalScore1 = Ball.finalScore1 + Ball.score1;
        Ball.finalScore2 = Ball.finalScore2 + Ball.score2;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        currentScene++;
        SceneManager.LoadScene(currentScene);
        Ball.maxScore = Ball.maxScore + 2;
        
    }
    public void QuitUnity()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public int GetIndex()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        return index;
    }
}