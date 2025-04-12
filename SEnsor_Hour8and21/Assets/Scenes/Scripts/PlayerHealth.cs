using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  int healthpoints = 3992;

   void Start()
    {
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        Debug.Log("Zell's Final Health: " + healthpoints);
    }

    void Update()
    {
        // This runs every frame
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}