using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentPointIndex = 0;
    [SerializeField] float speed = 1f;


    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,waypoints[currentPointIndex].transform.position)< .1f) 
        {
            currentPointIndex++;
            if(currentPointIndex >= waypoints.Length)
            {
                currentPointIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentPointIndex].transform.position, speed * Time.deltaTime);
        
    }
}
