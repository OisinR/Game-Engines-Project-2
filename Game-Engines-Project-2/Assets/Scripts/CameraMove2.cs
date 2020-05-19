using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour
{

    public GameObject cameraGO;

	void Start()
    {
        
    }




	private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - 0.005f, transform.position.y, transform.position.z - 0.01f);
    }



}
