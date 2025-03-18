using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health =1004f;
        float posiondamage = 125.5f;
        Debug.Log(health);
        health -=posiondamage;
        Debug.Log(health);
         health -=posiondamage;
        Debug.Log(health); 
        health -=posiondamage;
        Debug.Log(health); 
        health -=posiondamage;
        Debug.Log(health);
         health -=posiondamage;
        Debug.Log(health);
         health -=posiondamage;
         Debug.Log(health);
      health -=posiondamage;
         Debug.Log(health);
         health -=posiondamage;
         Debug.Log(health);
         Debug.Log ("player has been unalived!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
