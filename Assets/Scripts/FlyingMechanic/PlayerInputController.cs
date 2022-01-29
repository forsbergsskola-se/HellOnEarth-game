using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    public float flyInputVertical{ get; private set; }
    public float flyInputHorizontal { get; private set; }
   
    //Animation
    // [SerializeField] private Animator animator;
    // [SerializeField] private Vector2 bird;
   
    // Update is called once per frame
    void Update()
    {
        GetInput();
        SetCommands();
        //Animation
        // animator.SetFloat("Speed", bird.sqrMagnitude);
        // animator.SetFloat("Horizontal", bird.x);
        // bird = bird.normalized;
        // bird.x = Input.GetAxisRaw("Horizontal");
    }

    private void GetInput()
    {
        //get move input
        flyInputVertical = Input.GetAxis("Vertical");
        flyInputHorizontal = Input.GetAxis("Horizontal");
    }

    private void SetCommands()
    {
        commandContainer.flyCommandVectical = flyInputVertical;
        commandContainer.flyCommandHorizontal = flyInputHorizontal;
    }
    
}
