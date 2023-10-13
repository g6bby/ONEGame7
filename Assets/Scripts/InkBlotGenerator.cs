using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkBlotGenerator : MonoBehaviour
{
    public GameObject inkblotPrefab; // Assign your inkblot prefab in the Inspector
    public Transform[] pathWaypoints; // Define the path waypoints in the Inspector
    public float minInterval = 1.0f; 
    public float maxInterval = 5.0f;

    private int currentWaypointIndex = 0;
    private float nextSpawnTime = 0f;

    void Start()
    {
        // Set the initial spawn time
        nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime && currentWaypointIndex < pathWaypoints.Length)
        {
            // Instantiate an inkblot prefab at the current waypoint position
            Instantiate(inkblotPrefab, pathWaypoints[currentWaypointIndex].position, Quaternion.Euler(90f, 0f, 0f));

            // Move to the next waypoint
            currentWaypointIndex++;

            // Set the time for the next spawn
            nextSpawnTime = Time.time + Random.Range(minInterval, maxInterval);
        }
    }
}
