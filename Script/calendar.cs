using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calendar : MonoBehaviour
{
    [SerializeField] GameObject DatePicker;
    private bool state;
    private Button dateBtn;

    private void Start()
    {
        dateBtn = GetComponent<Button>();
        state = false;
    }

    public void datePickHandler()
    {
        if (DatePicker.activeSelf == true)
        {
            DatePicker.SetActive(false);

        }
        else
        {
            DatePicker.SetActive(true);
        }
       
    } 


}
