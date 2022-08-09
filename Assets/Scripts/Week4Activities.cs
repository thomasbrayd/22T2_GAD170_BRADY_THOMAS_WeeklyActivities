using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Week4Activities : MonoBehaviour
{

    public float year;
    public float celsius;
    public float farenheit;

    // Start is called before the first frame update
    void Start()
    {

        year = Random.Range(0, 2023);
        Debug.Log("The year is " + year);
        if (year % 4 == 0)
        {
            Debug.Log("It is a leap year.");
        }
        else
        {
            Debug.Log("It is not a leap year.");
        }

        farenheit = Random.Range(1, 130);
        Debug.Log("It is " + farenheit + " degrees farenheit.");
        celsius = (farenheit - 32) * 5/9;
        Debug.Log("This is " + celsius + " degrees in celsius.");

        if(celsius <= 0) //if celsius is 0 or below
        {
            Debug.Log("Freezing weather.");
        }
        else if(celsius <= 10) //if celsius is less than or equal 10
        {
            Debug.Log("Very cold weather.");
        }
        if(celsius <= 14) //if celsius is less than or equal to 14
        {
            Debug.Log("It's a bit cool.");
        }
        else if(celsius <= 20) //otherwise, if less than or equal to 20
        {
            Debug.Log("It's cold.");
        }
        //if(celsius >= 20)
       



        //if celsius is 11-20
        //if 
        //{
        //    Debug.Log("It's a bit cool.");
        //}
        //else if 
        //{
        //    Debug.Log("It's cold");
        //}

        //celsius greater or equal to 40 very hot
        if(celsius >= 40)
        {
            Debug.Log("Very hot.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
