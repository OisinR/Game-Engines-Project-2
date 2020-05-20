using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public LayerMask enemyLayer;
    public GameObject shootPoint;

    public GameObject projectile;

    public float cooldown = 0.2f;
    float lastTimeFired;

    AudioSource speaker;

    public AudioClip laser;

    void Start()
    {
        lastTimeFired = Time.time;
        speaker = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        Vector3 fwd = shootPoint.transform.TransformDirection(Vector3.forward);
        //Debug.Log(Physics.Raycast(shootPoint.transform.position, fwd, 15, enemyLayer));
        if (Physics.Raycast(shootPoint.transform.position, fwd, 15 ,enemyLayer) && Time.time > lastTimeFired + cooldown)
        {
            lastTimeFired = Time.time;
            FireWeapon();
        }

    }

    void FireWeapon()
    {
        GameObject bullet = Instantiate(projectile, shootPoint.transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(shootPoint.transform.forward * 3000);
        speaker.PlayOneShot(laser);
    }
}


