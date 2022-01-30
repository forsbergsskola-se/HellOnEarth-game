using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public bool chase = false;
    public Transform startingPoint;
   
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            return;
        }

        if (chase == true)
        {
            Chase();
        }
        else
        {
            //Go to starting position
           ReturnToStartPoint(); 
        }
        Flip();  
        
    }

    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    private void Flip()
    {
        if (transform.position.x > player.transform.position.x)
        {
           transform.rotation = Quaternion.Euler(0,0,0); 
        }
        else
        {
            transform.rotation = quaternion.Euler(0,180,0);
        }
    }

    private void ReturnToStartPoint()
    {
        transform.position = Vector2.MoveTowards(transform.position, startingPoint.position, speed * Time.deltaTime);
    }
}
