using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         {
        int count = 1;

        while (count <= 30)
        {
            print(count);
            count++;

            if (count == 2)
            {
                print("It's my birthday!");
            }
        }
    }
    
}
         

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
