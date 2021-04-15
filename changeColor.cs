using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    look lookScript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject gameObject;
    public void changeColorGreen()
    {
        //lookScript.changeColor();

        gameObject.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}
