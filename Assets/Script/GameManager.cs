using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ScoreUI scoreUI;
    int score = 0;
   
    public void UpdateScore()
    {
        score++;
        scoreUI.UpdateScore(score);
    }
    public void ScoreZone()
    {
        scoreUI.ScoreZone();
    }
    void Awake()
    {

    Ball ball = FindFirstObjectByType<Ball>();
        
    }
}
