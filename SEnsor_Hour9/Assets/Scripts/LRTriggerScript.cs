using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        {
            Debug.Log(other.gameObject.name + " has entered the LTritter or RTrigger.");
        }
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in LTrigger or RTrigger.");
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the triggers");
    }
}