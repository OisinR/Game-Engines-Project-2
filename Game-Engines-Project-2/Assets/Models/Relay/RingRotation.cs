using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotation : MonoBehaviour
{

    public bool yAxes;


    private void Update()
    {
        if(yAxes)
        {
            transform.Rotate(0f,1f,0f);
        }
        else
        {
            transform.Rotate(0f, 0f, 1f);
        }
    }

}
