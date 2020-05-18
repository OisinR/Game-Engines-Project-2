using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurn : MonoBehaviour
{
    float end = 25f;

    public GameObject normandy;

    Vector3 endRot = new Vector3(-5,15,0.33f);
    Quaternion endRot2;

    void Start()
    {
        endRot2 = Quaternion.Euler(endRot);
    }




	private void Update()
    {
        transform.LookAt(normandy.transform);
    }



}
