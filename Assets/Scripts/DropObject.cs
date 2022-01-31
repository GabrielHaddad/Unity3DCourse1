using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    [SerializeField] float timeToDrop = 3f;
    Rigidbody rb;
    MeshRenderer meshRenderer;

    void Awake() 
    {
        rb = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToDrop)
        {
            rb.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}
