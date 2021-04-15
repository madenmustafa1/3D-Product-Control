using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeButton : MonoBehaviour
{
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public GameObject product1;
    public GameObject product2;

    public GameObject product1Pervane;
    public GameObject product2Pervane;


    public void changeServo()
    {


        if(product1Pervane.gameObject.GetComponent<Renderer>().enabled || product2.gameObject.GetComponent<Renderer>().enabled)
        {
            product1Pervane.gameObject.GetComponent<Renderer>().enabled = false;
            product2Pervane.gameObject.GetComponent<Renderer>().enabled = false;
        }
        product2.gameObject.GetComponent<Renderer>().enabled = !product2.gameObject.GetComponent<Renderer>().enabled;
        product1.gameObject.GetComponent<Renderer>().enabled = !product1.gameObject.GetComponent<Renderer>().enabled;

    }
    public void changeMotor()
    {
        if (product1.gameObject.GetComponent<Renderer>().enabled)
        {

            product1Pervane.gameObject.GetComponent<Renderer>().enabled = !product1Pervane.gameObject.GetComponent<Renderer>().enabled;
        }
        else if(product1.gameObject.GetComponent<Renderer>().enabled == false)
        {
            product1Pervane.gameObject.GetComponent<Renderer>().enabled = false;
        }
        if (product2.gameObject.GetComponent<Renderer>().enabled)
        {
            product2Pervane.gameObject.GetComponent<Renderer>().enabled = !product2Pervane.gameObject.GetComponent<Renderer>().enabled;
        }
        else if (product2.gameObject.GetComponent<Renderer>().enabled == false)
        {
            product2Pervane.gameObject.GetComponent<Renderer>().enabled = false;
        }
        
    }
}
