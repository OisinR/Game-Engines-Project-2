﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public List<GameObject> waypoints = new List<GameObject>();
    public int next = 0;
    public bool looped = true;

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        int count = (looped) ? waypoints.Count + 1 : waypoints.Count;
        for (int i = 1; i < count; i++)
        {
            int prev = i - 1;
            int next = i % waypoints.Count;
            Gizmos.DrawSphere(waypoints[prev].transform.position, 1f);
            Gizmos.DrawLine(waypoints[prev].transform.position, waypoints[next].transform.position);
        }
        if (!looped)
        {
            Gizmos.DrawSphere(waypoints[waypoints.Count - 1].transform.position, 1f);
        }
    }


    public Vector3 NextWaypoint()
    {
        return waypoints[next].transform.position;
    }

    public void AdvanceToNext()
    {
        if (looped)
        {
            next = (next + 1) % waypoints.Count;
        }
        else
        {
            if (!IsLast())
            {
                next++;
            }
        }
    }

    public bool IsLast()
    {
        return (next == waypoints.Count - 1);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}