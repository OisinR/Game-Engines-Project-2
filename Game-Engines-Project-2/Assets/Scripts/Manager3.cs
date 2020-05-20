using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager3 : MonoBehaviour
{


    public float waitTime = 3;
    public int sceneNo = 4;

    public static bool goNow;

    void Update()
    {
        if (goNow)
        {
            Invoke("ChangeScene", waitTime);
            goNow = false;
        }
    }




    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneNo);
    }



}
