using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] Canvas finishCanvas;

    void Start() 
    {
        finishCanvas.enabled = false;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            finishCanvas.enabled = true;
            Time.timeScale = 0;
        }
    }
}
