using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpHandler : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;

    public float jumpForce;

    public float rayLenght;
    [SerializeField]private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float extraHeight = .01f;
        Debug.DrawRay(boxCollider.bounds.center, Vector3.down * (boxCollider.bounds.extents.y + extraHeight), Color.black);
        if (Physics2D.Raycast(boxCollider.bounds.center, Vector2.down, boxCollider.bounds.extents.y + extraHeight))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        
        if (Input.GetButton("Jump") && isGrounded)
        {
            //rigidbody.AddForce(new Vector2(0, jumpForce));
            rigidbody.velocity = Vector2.up * jumpForce;
        }
    }
}
