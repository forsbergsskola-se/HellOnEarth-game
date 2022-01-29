using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControllerController : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    public LayerMask playerLayer;
    private Collider2D collider2D;

    private void OnTriggerEnter2D(Collider2D col)
    {
        collider2D = GetComponent<Collider2D>();
        if (collider2D.IsTouchingLayers(playerLayer))
        {
            if (cam1.activeInHierarchy)
            {
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else if (cam2.activeInHierarchy)
            {
                cam1.SetActive(true);
                cam2.SetActive(false);
            }
        }
    }
}
