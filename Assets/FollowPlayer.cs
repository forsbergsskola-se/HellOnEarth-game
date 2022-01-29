using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject oden;
    [SerializeField] private GameObject bird;
    private void Start()
    {
        
    }

    void Update()
    {
        if(oden.activeInHierarchy) transform.position = oden.transform.position;
        else if (bird.activeInHierarchy) transform.position = bird.transform.position;
        
    }
}
