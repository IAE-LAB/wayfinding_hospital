using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class primarybutton : MonoBehaviour
{
    public XRBaseController XRControllerState;

    bool rightHandLastState = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        rightHandLastState = false; // Assumed not held when starting game, while also initializing the value

       
    }

    // Update is called once per frame
    void Update()
    {
        InteractionState text = XRControllerState.activateInteractionState;
        Debug.Log(text);
    }
}
