using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObjectScript : MonoBehaviour
{
    public Transform Balloon;
    public Transform String;
    public Transform Cargo;
    private bool isTriggered = false;
    public float Speed = 0.01f;
    void Start()
    {
        Balloon = transform.GetChild(0);
        String = transform.GetChild(1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.tag);
        if (other.tag == "Room")
        {
            Speed = -Speed;
        }
        if (other.tag == "Arrow")
        {
            if (!isTriggered)
            {
                Destroy(Balloon.gameObject);
                Balloon.parent = null;
                Destroy(String.gameObject);
                String.parent = null;
                //if (Cargo != null)
                //{
                    Cargo.transform.parent = null;
                    Cargo.transform.name = Cargo.transform.name.Substring(0, Cargo.transform.name.Length - 7);
                    Cargo.gameObject.AddComponent<Rigidbody>();
                    Cargo.GetComponent<Rigidbody>().useGravity = true;
                //}
                Destroy(gameObject);
                isTriggered = true;
            }
        }
    }
}
