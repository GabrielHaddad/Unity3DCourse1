using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] Color32 hitColor;
    MeshRenderer meshRenderer;
    Score score;

    void Awake() 
    {
        score = FindObjectOfType<Score>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Player") && !gameObject.CompareTag("Hit"))
        {
            gameObject.tag = "Hit";
            meshRenderer.material.color = hitColor;
            score.AddToScore();
        }
    }
}
