using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GethShoot : MonoBehaviour
{

    public GameObject projectile;


    void Start()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }


}
