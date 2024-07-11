using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text fainalScoreText;
    int myScore = 0;

    void Update()
    {
        scoreText.text = myScore.ToString();
        fainalScoreText.text = "Score: "+ myScore.ToString();
    }
    public void AddScore(int score)
    {
        myScore = myScore + score;
    }
}