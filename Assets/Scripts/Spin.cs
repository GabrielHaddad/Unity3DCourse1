using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float rotation = 1f;
    void Update()
    {
        transform.Rotate(new Vector3(0f, rotation * Time.deltaTime, 0f));
    }
}
