using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeWhenClose : MonoBehaviour
{

    public float min, max;

    public Boid target;

    Flee flee;
    Pursue pursue;

	void Start()
    {
        flee = GetComponent<Flee>();
        pursue = GetComponent<Pursue>();

        target = pursue.target[pursue.targetno];
    }




	private void Update()
    {
        //Debug.Log(Vector3.Distance(transform.position, target.transform.position));

        if(target == null)
        {
            return;
        }

        if(Vector3.Distance(transform.position, target.transform.position) < min)
        {
            flee.enabled = true;
        }

        if(Vector3.Distance(transform.position, target.transform.position) > max)
        {
            flee.enabled = false;
            
        }
    }



}
