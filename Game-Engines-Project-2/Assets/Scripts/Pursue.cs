using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursue : SteeringBehaviour
{
    public Boid[] target;

    public GameObject carrot;

    Vector3 targetPos;

    public int targetno;

    public void Start()
    {

        SetTarget();
    }


    public void SetTarget()      
    {
        targetno = Random.Range(0, target.Length);
    }

    public void OnDrawGizmos()
    {
        if (Application.isPlaying && isActiveAndEnabled)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, targetPos);
        }
    }

    public override Vector3 Calculate()
    {

        if(target[targetno])
        {
            float dist = Vector3.Distance(target[targetno].transform.position, transform.position);
            float time = dist / boid.maxSpeed;

            targetPos = target[targetno].transform.position + (target[targetno].velocity * time);
            return boid.SeekForce(targetPos);
        }
        else
        {
            return boid.SeekForce(carrot.transform.position);
        }

        
    }
}
