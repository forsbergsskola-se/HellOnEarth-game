using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField] private WalkOnGround walkScript;
    [Range(-1f,1f)]  public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    
    void Update()
    {
        scrollSpeed = walkScript.movement.x;
        offset += (Time.deltaTime * scrollSpeed) / 10;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        ScrollBackground();
    }

    void ScrollBackground()
    {
        
    }
}
