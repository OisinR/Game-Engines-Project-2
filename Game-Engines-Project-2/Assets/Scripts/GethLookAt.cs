using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GethLookAt : MonoBehaviour
{

    public Transform target;

   //zxzczxc
	void Start()
    {
        
    }




	private void Update()
    {
        transform.LookAt(target);
    }



}
