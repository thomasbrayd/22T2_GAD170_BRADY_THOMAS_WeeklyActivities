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

        farenheit = Random.Range(1, 200);
        Debug.Log("It is " + farenheit + " degrees farenheit.");
        celsius = (farenheit - 32) * 5/9;
        Debug.Log("This is " + celsius + " degrees in celsius.");

        if(celsius <= 0)
        {
            Debug.Log("Freezing weather");
        }
        if (celsius > 0 && < 11)
        {
            Debug.Log("Very cold weather");
        }
        if (celsius > 10 && < 15)
        {
            Debug.Log("It's a bit cool.");
        }
        else if (celsius > 15 && < 21) ;
        {
            Debug.Log("It's cold");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
