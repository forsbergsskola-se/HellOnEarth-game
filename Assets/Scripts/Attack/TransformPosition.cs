using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public WalkOnGround lookDirection;
    public Transform playerPos;
    void Start()
    {
        playerPos = GameObject.Find("Player-holder").GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = lookDirection.movement.x <= -0.1 ? new Vector2(playerPos.position.x - 1.2f, .7f) : new Vector2(playerPos.position.x + 1f, .7f);
    }
}
