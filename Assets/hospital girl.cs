using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hospitalgirl : Player
{
    public hand Lefthand;

    public hand Righthand;

    public foot Leftfoot;

    public foot Rightfoot;

    public body body;

    //Update mothod
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            //call hook method
            hook();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //call hook method
            kicking();
        }
                if (Input.GetKeyDown(KeyCode.C))
        {
            //call hook method
            punchcombo();
        }
    }
    //punch method via animator
    public void hook()
    {
        //find animator component
        Animator animator = GetComponent<Animator>();

        animator.SetTrigger("hook");
    }
    //punch method via animator
    public void kicking()
    {
        //find animator component
        Animator animator = GetComponent<Animator>();

        animator.SetTrigger("kicking");
    }
    //punch method via animator
    public void punchcombo()
    {
        //find animator component
        Animator animator = GetComponent<Animator>();

        animator.SetTrigger("punchcombo");
    }

}
