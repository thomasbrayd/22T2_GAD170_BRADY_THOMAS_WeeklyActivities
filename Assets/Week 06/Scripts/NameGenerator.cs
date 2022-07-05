using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGenerator : MonoBehaviour
{
    [Header("List of favourite things")]
    public List<string> favouriteThings = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        CreateList();
    }

    public void CreateList()
    {
        favouriteThings.Add("Spiderman");
        favouriteThings.Add("Watermelon");
        favouriteThings.Add("Gangnam Style");
        favouriteThings.Add("Green");

        Debug.Log(favouriteThings);
    }
    
    public void
    {
        return;
    }

}