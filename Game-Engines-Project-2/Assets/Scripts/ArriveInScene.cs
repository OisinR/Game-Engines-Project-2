using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveInScene : MonoBehaviour
{

    [SerializeField] float stopPoint = 2f;
    [SerializeField] CameraTurn mCamera;

    public bool isNormandy;

    Boid boid;

    void Start()
    {
        boid = GetComponent<Boid>();
    }




	private void Update()
    {
       
        if(transform.position.z <= stopPoint)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
        }
        else
        {
            boid.enabled = true;
            if(isNormandy)
            {
                mCamera.enabled = true;
            }
        }
    }



}
