using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.Characters.FirstPerson;

namespace Arrow
{
    public class ArrowScript : MonoBehaviour
    {
        public static event Action ArrowPickUp;
        public UnityEvent onCollisionWithMovingObject;
        private float unspawnTime = 5f;
        bool StartCountDown = false;
        public bool isReleased = false;
        private void Start()
        {

        }
        private void Update()
        {
            if (isReleased)
            {
                if (StartCountDown)
                {
                    unspawnTime -= Time.deltaTime;
                    if (unspawnTime <= 0)
                    {
                        Destroy(gameObject);
                    }
                }
                //else transform.rotation = Quaternion.LookRotation(GetComponent<Rigidbody>().velocity);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.tag);
            if (other.tag == "Player" && !isReleased)
            {
                other.gameObject.GetComponent<FirstPersonController>().arrowsCount++;
                Destroy(gameObject);
            }
            if (isReleased)
            { 
            StartCountDown = true;
            if(other.tag!="Arrow")
            {
                
                if(other.tag=="MovingObject")
                {
                    unspawnTime = 0;
                }
                Stick();
            }
           }
        }
        private void Stick()
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
