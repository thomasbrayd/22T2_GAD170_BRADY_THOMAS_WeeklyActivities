using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class WeekThreeActivities : MonoBehaviour
    {
        private string firstName = "Thomas";
        private string lastName = "Brady";

        //player stats
        private int charStr = 10;
        private int charAgil = 7;
        private int charInt = 3;

        // Start is called before the first frame update
        void Start()
        {
            //function adds player strength, agility and intelligence integers 
            float powerLevel = (charStr * 2f + charAgil * 1.5f + charInt);

            //function converts player powerlevel float to int
            int powerLevelInt = (int)powerLevel;

            //function prints out name and powerlevel as int
            Debug.Log(firstName + " " + lastName);
            Debug.Log(powerLevelInt);

        }
    }

    // Update is called once per frame
    void Update()
    { 
          
    }
}

