using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostController : MonoBehaviour
{
    public Host host;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D hostRb2d;

    [HideInInspector]
    public bool isControlled = false;

    [SerializeField]
    internal HostInputScript hostInputScript;

    public string hostName;
    public float movementVelocity;
    public float jumpForce;
    public AnimatorOverrideController animatorOverrideController;

    // Start is called before the first frame update
    void Start()
    {   
        hostName = host.hostName;
        movementVelocity = host.movementVelocity;
        jumpForce = host.jumpForce;
        animatorOverrideController = host.animatorOverrideController;

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = host.hostSprite;

        hostRb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hostInputScript.isLeftScreenPressed == false && hostInputScript.isRightScreenPressed == true) 
        {
            spriteRenderer.color = Color.red;
        }
        else if(hostInputScript.isLeftScreenPressed == true && hostInputScript.isRightScreenPressed == false) 
        {
            spriteRenderer.color = Color.yellow;
        }
        else
        {
            spriteRenderer.color = Color.blue;
        }
    }
}
