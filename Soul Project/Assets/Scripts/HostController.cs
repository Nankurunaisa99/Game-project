using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostController : MonoBehaviour
{
    public Host host;
    //private SpriteRenderer spriteRenderer;
    //private Rigidbody2D hostRb2d;

    public string hostName;
    public float movementVelocity;
    public float jumpForce;
    //public AnimatorOverrideController animatorOverrideController;

    // Start is called before the first frame update

    private void Awake()
    {
        hostName = host.hostName;
        movementVelocity = host.movementVelocity;
        jumpForce = host.jumpForce;
    }
    void Start()
    {   
        //hostName = host.hostName;
        //movementVelocity = host.movementVelocity;
        //jumpForce = host.jumpForce;
        //animatorOverrideController = host.animatorOverrideController;

        //spriteRenderer = GetComponent<SpriteRenderer>();
        //spriteRenderer.sprite = host.hostSprite;

        //hostRb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
