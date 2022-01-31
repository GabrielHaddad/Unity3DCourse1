using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateRollers : MonoBehaviour
{
    [SerializeField] float zVariationDrop = 10f;
    [SerializeField] float yVariationDrop = 5f;
    [SerializeField] float xVariationDrop = 1f;
    [SerializeField] float timeBetweenRollers = 1f;
    [SerializeField] GameObject rollerPrefab;
    List<Transform> dropPositions = new List<Transform>();

    void Start()
    {
        InitiatePositions();
        StartCoroutine(Instantiate(dropPositions));
    }

    void Update()
    {

    }

    void InitiatePositions()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            dropPositions.Add(transform.GetChild(i));
        }
    }

    IEnumerator Instantiate(List<Transform> dropPositions)
    {
        while (true)
        {
            foreach (Transform drop in dropPositions)
            {
                float randomX = Random.Range(-xVariationDrop, xVariationDrop);
                float randomY = Random.Range(-yVariationDrop, yVariationDrop);
                float randomZ = Random.Range(-zVariationDrop, zVariationDrop);

                Vector3 newPos = new Vector3(drop.position.x + randomX, drop.position.y + randomY, drop.position.z + randomZ);

                Instantiate(rollerPrefab, newPos, Quaternion.identity);

                yield return new WaitForSeconds(timeBetweenRollers);
            }
        }
    }
}
