using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [SerializeField] private GameObject speechBubble;
    public TextMeshPro text;
    public LayerMask playerLayer;
    [SerializeField] private Collider2D colide;
    [SerializeField] private GameObject npcPop;

    public string line1;
    public string line2;
    public string line3;

    private bool nextLine1 = false;
    private bool nextLine2 = false;
    private bool nextLine3 = false;
    private bool nextLine4 = true;
    private void Update()
    {
        if (colide.IsTouchingLayers(playerLayer) && nextLine4 &&Input.GetKeyDown(KeyCode.E))
        {
            speechBubble.SetActive(true);
            text.text = line1;
            nextLine1 = true;
            nextLine4 = false;
        }
        else if (colide.IsTouchingLayers(playerLayer) && nextLine1 && Input.GetKeyDown(KeyCode.E))
        {
            text.text = line2;
            nextLine1 = false;
            nextLine2 = true;
        }
        else if (colide.IsTouchingLayers(playerLayer) && nextLine2 && Input.GetKeyDown(KeyCode.E))
        {
            text.text = line3;
            nextLine2 = false;
            nextLine3 = true;
        }
        else if (colide.IsTouchingLayers(playerLayer) && nextLine3 && Input.GetKeyDown(KeyCode.E))
        {
            nextLine3 = false;
            nextLine4 = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (colide.IsTouchingLayers(playerLayer))
        {
            npcPop.SetActive(true);
        }
    }
    
    

    private void OnTriggerExit2D(Collider2D other)
    {
        speechBubble.SetActive(false);
        npcPop.SetActive(false);
    }
}
