using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamgefromFireball ();
        print ("player health" + x);
    }
    // Methods call with
    int TakeDamgefromFireball ()
    { 
      int playerhealth = 100; 
      return playerhealth - 5;
    }
    int TakeDamgefromFireball (int damage)
    {
     int playerhealth = 100;
     return playerhealth - damage; 
    }
    int TakeDamgefromFireball (int damage, int playerhealth)
    {
     return playerhealth - damage; 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
