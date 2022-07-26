using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class Week9Activities : MonoBehaviour
    {
        private void OnTriggerEnter(Collider Sphere)
        {
            Debug.Log("The sphere has collided with the cube.");
        }
    }
}
