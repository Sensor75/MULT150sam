using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header ("Refrences")]
    public GameManager manager; 
    public Material normalMat; 
    public Material phasedMat;

    [Header ("Gameplay")]
    public float bounds = 3f;
    public float strafeSpeed = 4f; 
    public float phaseCooldown = 2f;

    Renderer mesh;
    Collider collison;
    bool canPhase = true;

    void Start()
    {
        mesh = GetComponentInChildren<SkinnedMeshRenderer>();
        collison = GetComponent<Collider>();
    }

    void Update()
    {

    float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

    Vector3 position = transform.position;
    position.x += xMove;

    position.x = Mathf.Clamp(position.x, -bounds, bounds);
    transform.position = position;

    if (Input.GetButtonDown("Jump") && canPhase) 
    {
        canPhase = false;
        mesh.material = phasedMat;
        collison.enabled = false;

        Invoke("PhaseIn", phaseCooldown);
    }
}
    void PhaseIn()
    {
      canPhase = true;
      mesh.material = normalMat;
      collison.enabled = true;
}   }
