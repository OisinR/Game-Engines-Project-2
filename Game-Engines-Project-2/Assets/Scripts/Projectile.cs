using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public bool isEnemy;

    public GameObject explosion;

    public float speed;

	void Awake()
    {
        Invoke("Despawn", 5);
    }




	private void FixedUpdate()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.SendMessage("TakeDamage");
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (isEnemy && collision.gameObject.tag == "Player")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


    void Despawn()
    {
        Destroy(gameObject);
    }

}
