using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable : MonoBehaviour
{
    public static int global = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
        Debug.Log(global);
    }

    
}
