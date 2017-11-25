using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_State : Node
{
    public override void Execute()
    {
        Debug.Log("I'm Attacking");
        Debug.Log("Attcking: " + curState);
    }
}
