using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForShooting : MonoBehaviour
//SHOOTING
{
    public Transform firePoint;
    public GameObject LightningPrefab;
    public float FireRate = 1.0f;
    public float NextFire = 1.0f;
    public float timeToDisappear = 5;
    public float range;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {         
        if (Vector2.Distance(transform.position, target.position) > range)
            return;
        if (Time.time > NextFire)
        {  
            NextFire = Time.time + FireRate;
            {
                Shoot();
            }
        }

    }

    void Shoot ()
    {
        Instantiate(LightningPrefab, firePoint.position, firePoint.rotation);
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
