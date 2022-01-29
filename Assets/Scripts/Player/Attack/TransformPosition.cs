using UnityEngine;

public class TransformPosition : MonoBehaviour
{
    public WalkOnGround lookDirection;
    public Transform playerPos;
    void Start()
    {
        playerPos = GameObject.Find("Oden").GetComponent<Transform>();
    }
    void Update()
    {
        transform.position = lookDirection.movement.x >= 0.1 ? new Vector2(playerPos.position.x + 1f, playerPos.position.y - 0.1f) : new Vector2(playerPos.position.x - 1.2f, playerPos.position.y - 0.1f);
    }
}
