using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayer;
    private Collider2D collider2;
    [SerializeField] private PlayerHealth ph;
    [SerializeField] private float damage;
    private void Start()
    {
        collider2 = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!collider2.IsTouchingLayers(playerLayer)) return;
        ph.currentHealth -= damage;
        ph.TakeDamage();
    }
}
