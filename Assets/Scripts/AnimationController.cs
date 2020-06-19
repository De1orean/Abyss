using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    Animator animator;

    float vertical;
    float horizontal;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

       // if (vertical == 0)
          //  animator.SetBool("Run", false);

        if (vertical >= 0.1 && horizontal == 0) 
            animator.SetBool("Run", true);
        else
            animator.SetBool("Run", false);

        //if (vertical >= 0.1 && horizontal >= 0.1)
        //    animator.SetBool("RunRightForward", true);
        //else
        //    animator.SetBool("RunRightForward", false);

        //if (vertical >= 0.1 && horizontal <= -0.1)
        //    animator.SetBool("RunLeftForward", true);
        //else
        //    animator.SetBool("RunLeftForward", false);
    }
}
