using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
        public static event TriggerAction OnTrigger;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("The sphere has collided with the cube.");
            //other.transform.position = new Vector3(0, 6, 0);

            if(OnTrigger != null)
            {
                OnTrigger();
            }
        }
    }
}
