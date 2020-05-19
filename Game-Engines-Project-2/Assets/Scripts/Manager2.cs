using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager2 : MonoBehaviour
{

    public float waitTime;
    public int sceneNo;

   //zxzczxc
	void Start()
    {
        Invoke("ChangeScene", waitTime);
    }




	private void ChangeScene()
    {
        SceneManager.LoadScene(sceneNo);
    }



}
