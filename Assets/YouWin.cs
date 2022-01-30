using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;
public class YouWin : MonoBehaviour
{
    public LayerMask playerLayer;
    private bool isItPlayer = false;
    private Collider2D collider2D;
    void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        isItPlayer = true;
    }

    void Update()
    {
        if (isItPlayer & collider2D.IsTouchingLayers(playerLayer))
        {
            LoadSceneAsync("WinScene");
        }
    }
}
