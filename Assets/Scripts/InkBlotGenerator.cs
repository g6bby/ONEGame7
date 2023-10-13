using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBlotGenerator : MonoBehaviour
{
    public GameObject inkblotPrefab;
    public Transform[] pathWaypoints;

    public float minInterval = 1.0f; 
    public float maxInterval = 5.0f;

    private float initialScale = 2.0f;
    private float scaleIncreaseAmount = 2.0f;

    private int currentWaypointIndex = 0;
    private float nextSpawnTime = 0f;
    private GameObject lastInkblot;

    void Start()
    {
        nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);

        lastInkblot = Instantiate(inkblotPrefab, pathWaypoints[0].position, Quaternion.Euler(90f, 0f, 0f));
        lastInkblot.transform.localScale = new Vector3(initialScale, initialScale, initialScale);
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime && currentWaypointIndex < pathWaypoints.Length)
        {
            if (lastInkblot != null)
            {
                float newScale = lastInkblot.transform.localScale.x + scaleIncreaseAmount;
                lastInkblot.transform.localScale = new Vector3(newScale, newScale, newScale);
            }

            GameObject newInkblot = Instantiate(inkblotPrefab, pathWaypoints[currentWaypointIndex].position, Quaternion.Euler(90f, 0f, 0f));
            lastInkblot = newInkblot;

            currentWaypointIndex++;

            nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);
        }
    }
}
