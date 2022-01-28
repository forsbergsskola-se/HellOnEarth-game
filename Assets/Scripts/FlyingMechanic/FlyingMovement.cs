using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingMovement : MonoBehaviour
{
    public float speed;
    public float acceleration;
    Rigidbody2D myBody;

    public float rotationControl;

    public float movY, movX = 1;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 vel = transform.right * (movX * acceleration);
        myBody.AddForce(vel);

        float dir = Vector2.Dot(myBody.velocity, myBody.GetRelativeVector(Vector2.right));

        if (acceleration > 0)
        {
            if (dir > 0)
            {
                myBody.rotation += movY * rotationControl * (myBody.velocity.magnitude / speed);
            }
            else
            {
                myBody.rotation -= movY * rotationControl * (myBody.velocity.magnitude / speed);
            }
        }

        float thrustForce = Vector2.Dot(myBody.velocity, myBody.GetRelativeVector(Vector2.down)) * 2.0f;

        Vector2 relForce = Vector2.up * thrustForce;
        
        myBody.AddForce(myBody.GetRelativeVector(relForce));

        if (myBody.velocity.magnitude > speed)
        {
            myBody.velocity = myBody.velocity.normalized * speed;
        }
        
    }
}
