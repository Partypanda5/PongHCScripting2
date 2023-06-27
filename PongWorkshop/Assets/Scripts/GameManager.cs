using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public Ball ball;

    public Paddle playerPaddle;
    public int playerScore;
    public TextMeshPro playerScoreText;

    public Paddle computerPaddle;
    public int computerScore;
    public TextMeshPro computerScoreText;

    void Start()
    {
        NewGame();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) 
        {
            NewGame();
        }
    }

    public void NewGame() 
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        StartRound();
    }

    public void StartRound() 
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.ResetPosition();
        ball.StartForce();
    }

    public void PlayerScores() 
    {
        SetPlayerScore(playerScore + 1);
        StartRound();
    }

    public void ComputerScores()
    {
        SetComputerScore(computerScore + 1);
        StartRound();
    }

    public void SetPlayerScore(int score) 
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    public void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }
}
