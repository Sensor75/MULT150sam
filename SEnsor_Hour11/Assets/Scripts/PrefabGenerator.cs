using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int itemCount = 10;
    public float spacing = 3f;

    void Start()
    {
        Vector3 startPosition = new Vector3(0, 1, 0); 

        for (int i = 0; i < itemCount; i++)
        {
            Vector3 position = startPosition + new Vector3(i * spacing, 0, 0); 
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
