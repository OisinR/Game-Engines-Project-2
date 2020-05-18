using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public GameObject[] ships;

    public float[] waitTimes;

    int counter = 0;

    bool canSpawn = true;

    float endPoint = 20;

	void Start()
    {
        
    }




	private void Update()
    {
        if(canSpawn && counter < ships.Length)
        {
            ships[counter].SetActive(true);
            StartCoroutine(waitForIt(waitTimes[counter]));
            counter++;
            canSpawn = false;
        }
        
        if(ships[3].transform.position.z >= endPoint)
        {
            SceneManager.LoadScene(1);
        }

    }


    IEnumerator waitForIt(float time)
    {
        yield return new WaitForSeconds(time);
        canSpawn = true;
    }
}
