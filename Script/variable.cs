using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
    public static int state = 0;

    public void change1()
    {
        state = 1;
        Debug.Log(state);
    }
}
