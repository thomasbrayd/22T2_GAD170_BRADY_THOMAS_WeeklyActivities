using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class SphereTeleporter : MonoBehaviour
    {
        private void OnEnable()
        {
            TriggerZone.OnTrigger += Teleport;
            EventManager.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            TriggerZone.OnTrigger -= Teleport;
            EventManager.OnClicked -= Teleport;
        }
        private void Teleport()
        {
            transform.position = new Vector3(Random.Range(-1, 1), Random.Range(5, 9), Random.Range(-1, 1));
        }
    }
}