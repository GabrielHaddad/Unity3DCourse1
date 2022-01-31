using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    float movementX;
    float movementZ;
    bool canJump = false;
    Rigidbody rb;
    bool isGrounded = false;

    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update() 
    {
        movementX = Input.GetAxis("Horizontal") * moveSpeed;
        movementZ = Input.GetAxis("Vertical") * moveSpeed;

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            canJump = true;
        }
    }

    void FixedUpdate()
    {
        Vector3 moveInput = new Vector3(movementX, rb.velocity.y, movementZ);
        rb.velocity = moveInput;

        if (canJump)
        {
            rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
            canJump = false;
            isGrounded = false;
        }
    }

    private void OnCollisionStay(Collision other) 
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
