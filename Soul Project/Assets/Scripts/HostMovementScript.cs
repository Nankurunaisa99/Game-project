using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostMovementScript : MonoBehaviour
{
    [SerializeField]
    Host_on_Screen_Detector host_on_Screen_Detector;

    private Rigidbody2D mainHostRB;

    private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        mainHostRB = host_on_Screen_Detector.host_List[0].GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(host_on_Screen_Detector.host_List[0].movementVelocity);
        if(host_on_Screen_Detector.hostInputScript.isRightScreenPressed == true && host_on_Screen_Detector.hostInputScript.isLeftScreenPressed == false)
        {
            if(facingRight == false)
            {
                Flip();
            }
            mainHostRB.AddForce(new Vector2(host_on_Screen_Detector.host_List[0].movementVelocity, 0), ForceMode2D.Force);
        }
        else if(host_on_Screen_Detector.hostInputScript.isRightScreenPressed == false && host_on_Screen_Detector.hostInputScript.isLeftScreenPressed == true)
        {   
            if(facingRight == true)
            {
                Flip();
            }
            mainHostRB.AddForce(new Vector2(-host_on_Screen_Detector.host_List[0].movementVelocity, 0), ForceMode2D.Force);
        }

    void Flip()
        {
            facingRight = !facingRight;
            Vector3 Scaler = host_on_Screen_Detector.host_List[0].transform.localScale;
            Scaler.x *= -1;
            host_on_Screen_Detector.host_List[0].transform.localScale = Scaler;
        }       
    }
}
