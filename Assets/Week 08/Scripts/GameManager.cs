using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Character>().morale -= Random.Range(1, 13);
            Debug.Log("Morale is now: " + GetComponent<Character>().morale);
            GetComponent<Character>().health -= Random.Range(1, 9);
            Debug.Log("Health is now:" + GetComponent<Character>().health);
        }       
    }
}
