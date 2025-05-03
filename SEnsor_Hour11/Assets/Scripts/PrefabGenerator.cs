using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int itemCount = 10;
    public Vector3 startPosition;
    public float spacing;

    void Start()
    {
        for (int i = 0; i < itemCount; i++)
        {
            Vector3 currentPosition = startPosition + Vector3.right * (i * spacing);
            GameObject newObject = Instantiate(prefab, currentPosition, Quaternion.identity);
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

