using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public GameObject parent;

    public GameObject otherShip;

    public float currentHealth = 10;

    public GameObject pathPos;
    public GameObject storePathPos;

    bool flipped;
    Transform newPos;
    Quaternion newRot;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(currentHealth <= 0)
        {
            if(!flipped)
            {
                flipped = true;
                currentHealth = 10;
                newPos = otherShip.transform;
                newRot = Quaternion.Euler(new Vector3(otherShip.transform.localRotation.x, otherShip.transform.localRotation.y, otherShip.transform.localRotation.z));
                Destroy(otherShip);
                parent.transform.position = newPos.position;
                parent.transform.rotation = newRot;
            }
            else
            {
                Manager3.goNow = true;
                Destroy(parent);
            }
            
        }
    }


    public void TakeDamage()
    {
        currentHealth--;
    }



}
