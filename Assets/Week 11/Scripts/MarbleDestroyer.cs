using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class MarbleDestroyer : MonoBehaviour
    {
        [SerializeField] private MarbleManager marbleManager;
        private void OnTriggerEnter(Collider other)
        {
            marbleManager.allMarbles.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
