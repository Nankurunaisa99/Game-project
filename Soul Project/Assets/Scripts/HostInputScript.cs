using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostInputScript : MonoBehaviour
{
    [SerializeField]
    HostController hostController;

    internal bool isLeftScreenPressed;
    internal bool isRightScreenPressed;

    float thirdScreenWidth;

    // Start is called before the first frame update
    void Start()
    {   
        //Divido lo schermo del cellulare in 3 in modo da tener traccia delle regioni in cui è stato effettuato il tocco
        thirdScreenWidth = Screen.width / 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
