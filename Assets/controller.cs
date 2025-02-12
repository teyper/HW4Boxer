using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            animator.SetTrigger("punches");
        }

        

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("dance");
            
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            animator.SetTrigger("kick");
            
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            animator.SetTrigger("jump");
        }

        /*if (Input.GetKeyUp(KeyCode.P) || Input.GetKeyUp(KeyCode.O) || Input.GetKeyUp(KeyCode.K) || Input.GetKeyUp(KeyCode.L))
        {
            animator.SetTrigger("idle");
            
        }*/
    }

   

}
