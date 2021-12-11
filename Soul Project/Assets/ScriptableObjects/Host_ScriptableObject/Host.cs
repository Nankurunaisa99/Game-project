using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Host", menuName = "ScriptableObjects/New Host", order = 0)]

public class Host : Host_Data
{
    public Sprite hostSprite;
    public string hostName;
    public float movementVelocity;
    public float jumpForce;
    public AnimatorOverrideController animatorOverrideController;

    public override void SpecialAction()
    {
        // Implement special action
    }

}
