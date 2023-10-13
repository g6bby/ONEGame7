using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBlotGenerator : MonoBehaviour
{
    public GameObject inkblotPrefab; 
    public float minInterval = 1.0f; 
    public float maxInterval = 5.0f;

    private float nextInkblotTime;

    void Start()
    {
        nextInkblotTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    void Update()
    {
        if (Time.time >= nextInkblotTime)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-10f, 10f), // Adjust the range as needed
                2.51f, 
                Random.Range(-10f, 10f)
            );

            GameObject newInkblot = Instantiate(inkblotPrefab, randomPosition, Quaternion.identity);

            newInkblot.transform.rotation = Quaternion.Euler(90f, 0f, 0f);

            nextInkblotTime = Time.time + Random.Range(minInterval, maxInterval);
        }
    }
}
