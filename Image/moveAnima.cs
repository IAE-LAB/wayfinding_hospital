using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAnima : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
      
    }

   
    public void Moveanimation(bool input)
    {
        if (input)
        {
            animator.SetTrigger("Right");
        }
        else
        {
            animator.SetTrigger("Left");
        }
    }

}
