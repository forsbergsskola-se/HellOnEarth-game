using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D myRigidbody;
    [SerializeField] private CommandContainer commandContainer;
    
    [SerializeField] private float flySpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleFlying();
    }
    private void HandleFlying()
    {
        //ToDO Create movement functionality
        myRigidbody.velocity = new Vector3( myRigidbody.velocity.x, commandContainer.flyCommandVectical * flySpeed, 0);
        myRigidbody.velocity = new Vector3( commandContainer.flyCommandHorizontal * flySpeed, myRigidbody.velocity.y, 0);
        
    }
    
    
    
}
