using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : SteeringBehaviour
{
    public GameObject targetGameObject = null;
    public Vector3 target = Vector3.zero;



    public void OnEnable()
    {
        Pursue pursue = GetComponent<Pursue>();
        pursue.SetTarget();
    }


    public void OnDrawGizmos()
    {
        if (isActiveAndEnabled && Application.isPlaying)
        {
            Gizmos.color = Color.cyan;
            if (targetGameObject != null)
            {
                target = targetGameObject.transform.position;
            }
            Gizmos.DrawLine(transform.position, target);
        }
    }

    public override Vector3 Calculate()
    {
        return -boid.SeekForce(target) * 1.5f ;
    }

    public void Update()
    {
        if (targetGameObject != null)
        {
            target = targetGameObject.transform.position;
        }
    }
}
