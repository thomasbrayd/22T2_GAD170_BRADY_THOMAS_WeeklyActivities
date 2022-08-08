using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
   public class CharacterColourChanger : MonoBehaviour
   {
        // We need a reference to the character we will change the colour of 
        [SerializeField] private MeshRenderer simpleCharacterRenderer;

        // Update is called once per frame
        void Update()
        {
            // We need to change the character's colour IF it has an X position < or > than 0 
            if (simpleCharacterRenderer.gameObject.transform.position.x > 0)
            {
                simpleCharacterRenderer.material.color = Color.green;
            }
            else
            {
                simpleCharacterRenderer.material.color = Color.red;
            }
        }
   }
}