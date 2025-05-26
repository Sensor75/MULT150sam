using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fouranimations : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scalling");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Hover");
        }
    }
}