using UnityEngine;

    public class ScoreZone : MonoBehaviour
    {
     private void OnTriggerEnter2D(Collider2D collision)
     {
        if (collision != null)
        {

            Ball ball = FindFirstObjectByType<Ball>();
            ball.ResetPosition();
            GameManager gameManager = FindFirstObjectByType<GameManager>();
            gameManager.ScoreZone();


        }
    }
    }
