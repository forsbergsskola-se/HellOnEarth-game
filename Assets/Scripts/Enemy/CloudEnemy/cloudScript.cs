using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudScript : MonoBehaviour
{
    public float Range;
    public Transform Target;
    bool Detected = false;
    Vector2 Direction;
    public GameObject Gun;
    public GameObject bullet;
    public float FireRate;
    float nextTimeToFire = 0;
    public Transform Shootpoint;
    public float Force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 targetPos = Target.position;
        Direction = targetPos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position,Direction,Range);
        if (rayInfo)
        {
            if(rayInfo.collider.gameObject.tag == "Player")
            {
                if (Detected == false)
                {
                    Detected = true;
                }
            }
            else
            {
                if (Detected == true)
                {
                    Detected = false;
                }
            }
        }
        if (Detected)
        {
            Gun.transform.up = Direction;
            if(Time.time > nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1 / FireRate;
                shoot();
            }
        }
    }
    void shoot()
    {
        GameObject BulletIns = Instantiate(bullet, Shootpoint.position, Quaternion.identity);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(Direction * Force);
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, Range);
    }
}
// {
//     public float Range;
//     public Transform Target;
//     private bool Detected = false;
//     private Vector2 Direction;
//
//     public GameObject AlarmLight;
//
//     public GameObject Lightning;
//     // Start is called before the first frame update
//     void Start()
//     {
//         
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         Vector2 targetPos = Target.position;
//
//         Direction = targetPos - (Vector2)transform.position;
//         
//         RaycastHit2D rayInfo = Physics2D.Raycast(transform.position,Direction,Range);
//
//         if (rayInfo)
//         {
//             if(rayInfo.collider.gameObject.tag == "Player")
//             {
//                 if (Detected == false)
//                 {
//                     Detected = true;
//                     AlarmLight.GetComponent<SpriteRenderer>().color = Color.red;
//                 }
//             }
//             else
//             {
//                 if (Detected == true)
//                 {
//                     Detected = false;
//                     AlarmLight.GetComponent<SpriteRenderer>().color = Color.green;
//                 }
//             }
//         }
//
//         if (Detected)
//         {
//             Lightning.transform.up = Direction;
//         }
//     }
//
//     private void OnDrawGizmosSelected()
//     {
//         Gizmos.DrawWireSphere(transform.position,Range);
//     }
// }
