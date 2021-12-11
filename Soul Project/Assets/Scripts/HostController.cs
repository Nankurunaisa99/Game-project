using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostController : MonoBehaviour
{
    public Host host;

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
        SpriteRenderer hostSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        hostSpriteRenderer.sprite = host.hostSprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
