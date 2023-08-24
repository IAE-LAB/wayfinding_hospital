using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private UnityEngine.UI.Button btn;
    [SerializeField] GameObject gameObject;
    private void Start()
    {
        btn = GetComponent<UnityEngine.UI.Button>();
        if (gameObject.activeSelf)
        {
            Debug.Log("aaa");
            btn.Select();
        }
    }

    private void Update()
    {
        
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
}
