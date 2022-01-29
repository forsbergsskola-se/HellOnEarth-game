using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControllerController : MonoBehaviour
{
    [SerializeField] private GameObject forest;
    [SerializeField] private GameObject hell;
    [SerializeField] private GameObject forestCam;
    [SerializeField] private GameObject hellCam;
    public LayerMask playerLayer;
    private Collider2D hellTransition;

    private void OnTriggerEnter2D(Collider2D col)
    {
        hellTransition = GetComponent<Collider2D>();
        if (hellTransition.IsTouchingLayers(playerLayer))
        {
            if (forest.activeInHierarchy)
            {
                forest.SetActive(false);
                forestCam.SetActive(false);
                hell.SetActive(true);
                hellCam.SetActive(true);
            }
            else if (hell.activeInHierarchy)
            {
                forest.SetActive(true);
                forestCam.SetActive(true);
                hell.SetActive(false);
                hellCam.SetActive(true);
            }
        }
    }
}
