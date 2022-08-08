using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private MeshRenderer characterRenderer;
    public int health = 100;
    public int morale = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Morale is: " + morale);
        Debug.Log("Health is: " + health);
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
        
        if(morale <= 50)
        {
            characterRenderer.material.color = Color.blue;
        }
    }
}
