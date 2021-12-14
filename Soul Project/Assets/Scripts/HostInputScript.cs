using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostInputScript : MonoBehaviour
{
    [SerializeField]
    Host_on_Screen_Detector host_on_Screen_Detector;

    internal bool isLeftScreenPressed;
    internal bool isRightScreenPressed;

    float thirdScreenWidth;

    int leftFingerID;
    int rightFingerID;

    // Start is called before the first frame update
    void Start()
    {
        leftFingerID = -1;
        rightFingerID = -1;

        isLeftScreenPressed = false;
        isRightScreenPressed = false;

        //Divido lo schermo del cellulare in 3 in modo da tener traccia delle regioni in cui è stato effettuato il tocco
        thirdScreenWidth = Screen.width / 3;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < Input.touchCount; i++)
        {
            Touch t = Input.GetTouch(i);

            switch (t.phase)
            {
                case TouchPhase.Began:

                    if(t.position.x < thirdScreenWidth && leftFingerID == -1)
                    {
                        leftFingerID = t.fingerId;
                        isLeftScreenPressed = true;
                        //Debug.Log("Left screen pressed");

                    }
                    else if(t.position.x > 2*thirdScreenWidth && rightFingerID == -1)
                    {
                        rightFingerID = t.fingerId;
                        isRightScreenPressed = true;
                        //Debug.Log("Right screen pressed");
                    }
                    break;

                case TouchPhase.Ended:
                case TouchPhase.Canceled:

                    if(t.fingerId == leftFingerID)
                    {
                        leftFingerID = -1;
                        isLeftScreenPressed = false;
                        //Debug.Log("Left screen not pressed anymore");
                    }
                    else if(t.fingerId == rightFingerID)
                    {
                        rightFingerID = -1;
                        isRightScreenPressed = false;
                        //Debug.Log("Right screen not pressed anymore");
                        
                    }
                    break;
            }
        }
        
    }
}
