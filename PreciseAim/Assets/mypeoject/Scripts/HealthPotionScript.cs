using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class HealthPotionScript : MonoBehaviour
{
    public int Ammount=30;
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log(other.tag);
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<FirstPersonController>().healthOwned+=Ammount;
            Destroy(gameObject);
        }   
    }
}
