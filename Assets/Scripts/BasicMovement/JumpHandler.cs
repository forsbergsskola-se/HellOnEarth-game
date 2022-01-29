using UnityEngine;

public class JumpHandler : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;

    public float jumpForce;

    public float rayLenght;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawRay(boxCollider.bounds.center, Vector3.down * rayLenght, Color.black);
        if (Physics2D.Raycast(transform.position, Vector2.down, rayLenght) )
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
