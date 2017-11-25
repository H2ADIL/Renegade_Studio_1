using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun_State : Node
{
    public float EMPDuration;   //Variable will be decreased with Time.deltaTime
    public float EMPTime;   //EMPDuration reset value
    public bool isStunned = false;

    public override void Execute()
    {
        Debug.Log("I'm Stunned");
    }

    /*
     void Update()
     {
        if (isStunned)
            Patrol();
        else
            ReversePatrol();

        else
        {
            EMPDuration -= Time.deltaTime;
            if (EMPDuration <= 0)
                isStunned = false;
        }
     }
     */

    void Stun()
    {
        /*
         isStunned = true;
         EMPDuration = EMPTime;
         */
    }
}