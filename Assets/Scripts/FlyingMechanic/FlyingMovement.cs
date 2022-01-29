using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FlyingMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private Animator animator;
    [SerializeField] private float flySpeed = 5f;
    public float gravity;
    private Vector2 flyVector;   

    // Update is called once per frame
    void Update()
    {
        flyVector.x = commandContainer.flyCommandHorizontal;
        animator.SetFloat("Speed", flyVector.sqrMagnitude);
        animator.SetFloat("Horizontal", commandContainer.flyCommandHorizontal);
        HandleFlying();
    }
    private void HandleFlying()
    {
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3( myRigidbody.velocity.x, commandContainer.flyCommandVectical * flySpeed, 0);
        myRigidbody.velocity = new Vector3( commandContainer.flyCommandHorizontal * flySpeed, myRigidbody.velocity.y - gravity, 0);
        
      
    }
    
    
    
}
