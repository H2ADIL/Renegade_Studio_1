using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_State : Node
{
    public override void Execute()
    {
       if (Vector3.Distance(_BehaviorTree.transform.position, _BehaviorTree.Player.transform.position) < 5f)
        {
            _BehaviorTree.PlayerScript.isDead = true;
        }

        curState = Results.SUCCESS;
        return;
    }
}


/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAttack : Node
{
    public GameObject player1;
    public PlayerClass playerscript;

    public override void NodeAction()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
        playerscript = player1.GetComponent<PlayerClass>();
        playerscript.IsDead = true;
        //ROB.PC.IsAlive = false;
        //ROB.PC.IsDead = true;
        Success();
        return;
    }
}
 */
