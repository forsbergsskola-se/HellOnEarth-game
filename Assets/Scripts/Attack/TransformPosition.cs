using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public WalkOnGround lookDirection;
    public MeleeAttack meleeAttack;
    public Transform playerPos;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("Player-holder").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = lookDirection.movement.x <= -0.1 ? new Vector2(playerPos.position.x - 1.2f, .7f) : new Vector2(playerPos.position.x + 1f, .7f);
    }
}
