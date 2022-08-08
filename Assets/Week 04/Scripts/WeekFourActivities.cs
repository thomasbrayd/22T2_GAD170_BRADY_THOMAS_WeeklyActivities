using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekFourActivities : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        int currentYear = Random.Range(1, 2023);
        Debug.Log("Year: " + currentYear);

        if (currentYear % 400 == 0)
        {
            Debug.Log("It is a leap year");
        }
        else
        {
            Debug.Log("It is not a leap year.");
        }

        int fahrenheit = Random.Range(1, 200);
        Debug.Log("It is " + fahrenheit + " degrees farenheit.");

        int celsius = (fahrenheit - 32) * 5 / 9;
        Debug.Log("This is " + celsius + " degrees in celsius.");

        if (celsius < 0)
        {
            Debug.Log("Freezing weather.");
        }
        else if (celsius >= 0 && celsius < 10)
        {
            Debug.Log("Very cold weather.");
        }
        else if ((celsius > 10 && celsius < 20) || celsius < 13)
        {
            Debug.Log("It's cold.");
        }
        else if (celsius == 14)
        {
            Debug.Log("It's a bit cold.");
        }
        else if (celsius > 13 && celsius < 20)
        {
            Debug.Log("It's a bit chilly.");
        }
        else if (celsius > 20 && celsius < 30)
        {
            Debug.Log("Normal weather.");
        }
        else if (celsius > 30 && celsius < 40)
        {
            Debug.Log("Nice weather today.");
        }
        else if (celsius < 35)
        {
            Debug.Log("Nice weather for fish & chips.");
        }
        else if (celsius < 37 && celsius > 35)
        {
            Debug.Log("Getting warmer.");
        }
        else if (celsius > 35 && celsius < 40)
        {
            Debug.Log("Its hot.");
        }
        else
        {
            Debug.Log("We're all going to burn.");
        }
    }
}