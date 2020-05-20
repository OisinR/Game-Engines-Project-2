using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager4 : MonoBehaviour
{
    public GameObject text;


	void Start()
    {
        Invoke("ShowText", 5);
    }


	private void ShowText()
    {
        text.SetActive(true);
    }

    public void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }

}
