using UnityEngine;

public class JumpHandler : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    public float jumpForce;
    public float rayLenght;
    public bool _isGrounded;

    public LayerMask ground;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down, rayLenght, ground))
        {
            _isGrounded = true;
        }
        else
        {
            _isGrounded = false;
        }

        //Debug.DrawRay(boxCollider.bounds.center, Vector3.down * rayLenght, Color.black);
         
        if (Input.GetButton("Jump") && _isGrounded)
        {
            //rigidbody.AddForce(new Vector2(0, jumpForce));
            _rigidbody.velocity = Vector2.up * jumpForce;
        }
    }
}
