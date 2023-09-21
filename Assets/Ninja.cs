using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : Player
{
    
    public Body MainBody;

    public Hand LeftHand;

    public Hand RightHand;

    public Foot LeftFoot;

    public Foot RightFoot;

    public void Update()
    {
    if(Input.GetKeyDown(KeyCode.K))
    {
        Kick();
    }
    }

    public void Kick()
    {
        Animator animator = GetComponent<Animator>();

        animator.SetTrigger("Kick");
    }
}
