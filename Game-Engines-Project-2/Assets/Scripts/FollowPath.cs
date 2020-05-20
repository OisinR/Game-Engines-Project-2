using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : SteeringBehaviour
{

    public Path path;

    Vector3 nextWaypoint;

    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(transform.position, nextWaypoint);
        }
    }

    float skipTime;

    public override Vector3 Calculate()
    {
        
        nextWaypoint = path.NextWaypoint();
        if (Vector3.Distance(transform.position, nextWaypoint) < 6 || Time.time > skipTime + 5)
        {
            skipTime = Time.time;
            path.AdvanceToNext();
        }

        if (!path.looped && path.IsLast())
        {
            return boid.ArriveForce(nextWaypoint, 20);
        }
        else
        {
            return boid.SeekForce(nextWaypoint);
        }
    }
}
