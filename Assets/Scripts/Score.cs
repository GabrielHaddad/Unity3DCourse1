using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = 0;

    public void AddToScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
