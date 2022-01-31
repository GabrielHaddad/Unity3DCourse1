using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bumpCount;
    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        bumpCount.text = "Bump Count: " + score.GetScore();
    }
}
