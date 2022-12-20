using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class checkGrab1 : MonoBehaviour
{
    public XRDirectInteractor interactor = null;
    public XRInteractorEvent selectEvent = null;
    static bool IsGrabbing;
    // 오디오 소스 생성해서 추가
    public AudioSource audioSource;

    private void Awake()
    {

        //interactor = GetComponent<XRDirectInteractor>();
        IsGrabbing = false;
        

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(interactor.isSelectActive);
        /*selectEvent = interactor.onSelectEntered;
        if (selectEvent != null)
        {
            Debug.Log(interactor.isSelectActive);
        }*/
        if (interactor.isSelectActive == true && IsGrabbing == false)
        {
            IsGrabbing = true;
            audioSource.Play();
        }else if (interactor.isSelectActive == false && IsGrabbing == true)
        {
            IsGrabbing = false;
        }

           if (IsGrabbing == true)
        {
            Variable.global++;
        }
    }
}
