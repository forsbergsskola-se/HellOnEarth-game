using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSystem : MonoBehaviour
{
    public float flyingSpeed;
    public float rotationForce;
    private Rigidbody2D myBody;
    public float flyInput = 0.0f;
    private bool moving = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     // myBody.AddForce(transform.up * flyingSpeed * Time.deltaTime);
        // }

        if (Input.GetKey(KeyCode.W))
        {
            myBody.velocity = new Vector2(0.0f, 2.0f);
            moving = true;
            flyInput = 0.0f;
        }




        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationForce * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.back * rotationForce * Time.deltaTime);
        }
    }

    // private void GetInput()
    // {
    //     flyInput = Input.GetAxis("Vertical");
    // }
    //
    // private void HandleFlying()
    // {
    //     var moveInput = Input.GetAxis("Vertical");
    //
    //     myBody.velocity = new Vector2(flyInput * flyingSpeed, myBody.velocity);
    // }
}
