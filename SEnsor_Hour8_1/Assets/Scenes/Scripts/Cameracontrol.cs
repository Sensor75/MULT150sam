using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrol : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust speed as needed

    void Update()
    {
        float moveX = Input.GetAxisRaw("Mouse X");
        float moveY = Input.GetAxisRaw("Mouse Y");

        // Move the camera based on mouse movement
        transform.Translate(new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime, Space.World);
    }
}
