using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class checkGrab : XRBaseInteractor
{
    //public XRBaseInteractor interactor = null;
    public bool IsGrabbing;
    /*private void Awake()
    {
        
        //interactor = GetComponent<XRDirectInteractor>();
        IsGrabbing = false;
        
        //Debug.Log(selectTarget.gameObject);

    }
*/
    void ClearInteractorSelection(XRBaseInteractor interactor)
    {
        // TODO: Make sure SelectExit is called if the selectTarget of the interactor is destroyed (and write a test around this).
        /*if (interactor.selectTarget &&
            (!interactor.isSelectActive || !interactor.CanSelect(interactor.selectTarget) || !interactor.selectTarget.IsSelectableBy(interactor)))
            SelectExit(interactor, interactor.selectTarget);*/
    }

    // Start is called before the first frame update
    void Start()
    {
        //interactor.selectTarget.gameObject
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
