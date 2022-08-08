using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class DamageObject : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {     
            if (collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().health -= 10;

                if (collision.gameObject.GetComponent<Health>().health <= 0)
                {
                    Destroy(collision.gameObject);
                }
            }          
        }
       
    }
}