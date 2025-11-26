using System;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI ScorePlayer1;
    public TextMeshProUGUI ScorePlayer2;


    public void UpdateScore(int score)
    {
        ScorePlayer1.text = score.ToString();
        ScorePlayer2.text = score.ToString();
    }

    internal void ScoreZone()
    {
        throw new NotImplementedException();
    }
}
