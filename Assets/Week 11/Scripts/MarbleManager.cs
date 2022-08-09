using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ThomasBrady
{
    public class MarbleManager : MonoBehaviour
    {
        //spawn a marble every few seconds
        //need to use 'instantiate' method 
        // Start is called before the first frame update

        [SerializeField] private GameObject marbleSpawnPoint;
        [SerializeField] private GameObject marblePrefab;

        [SerializeField] private float timer;
        [SerializeField] private float timerReset = 3;

        [SerializeField] private Vector3 averageMarblePosition;

        public List<GameObject> allMarbles = new List<GameObject>();

        private void Start()
        {
            timer = timerReset;
        }
        // Update is called once per frame
        void Update()
        {
           timer -= Time.deltaTime;

           if(timer < 0)
           {
               timer = timerReset;

               //spawn a marble
               GameObject newMarble = Instantiate(marblePrefab, marbleSpawnPoint.transform.position, Quaternion.identity);

               //adds a force to make our newly spawned marble faster
               newMarble.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -100));

               //adds new marble to list of all marbles
               allMarbles.Add(newMarble);
           }
           
            UpdateCameraLook();
        }            
        private void UpdateCameraLook()
        {
            if(allMarbles.Count > 0)
            {
                for (int i = 0; i < allMarbles.Count; i++)
                {
                    averageMarblePosition += allMarbles[i].transform.position;
                }
                averageMarblePosition /= allMarbles.Count;

                Camera.main.transform.LookAt(averageMarblePosition);
            }
        }            
    }
}