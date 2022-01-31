using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float movementX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float movementZ = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(movementX, 0f, movementZ);
    }
}
