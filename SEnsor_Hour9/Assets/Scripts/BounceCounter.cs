using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int bounceCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            bounceCount++;
            Debug.Log("Bounce count: " + bounceCount);
        }
    }
}