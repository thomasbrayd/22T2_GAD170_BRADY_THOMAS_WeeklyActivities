using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class WeekTwoActivities : MonoBehaviour
    {
        // My favourite game, my hours played, and its cost
        private string favouriteGame = "Mount & Blade: Warband";
        private int hoursPlayed = 600;
        private float gameCost = 1.50f;
        
        // Start is called before the first frame update
        void Start()
        {
            //OPERATORS
            // + add
            // - subtract
            // / divide
            // * multiply 

            float dollarsPerHour;
            dollarsPerHour = gameCost / hoursPlayed;

            Debug.Log ("My Favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + ", and it cost me $" + gameCost + ". Therefore, my value of dollars per hour is $" + dollarsPerHour);

        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
