using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase_State : Node
{
    //bool move = true;

    public override void Execute()
    {
        curState = Results.RUNNING;
        /*
        List<Vector3> Pathfinder = PathfindingManager._instance.GetPath(_BehaviorTree.transform.position, _BehaviorTree.Player.transform.position);
        
     _BehaviorTree.transform.position =  Vector3.MoveTowards(_BehaviorTree.transform.position, Pathfinder[1], _BehaviorTree.speed);
     */

        /*
        curState = Results.FAILED;
        Debug.Log("Chase "+curState.ToString());
        if (move && Vector3.Distance(_BehaviorTree.Player.transform.position, _BehaviorTree.transform.position) < 10f)
        {
            _BehaviorTree.transform.position = Vector3.MoveTowards(_BehaviorTree.transform.position, _BehaviorTree.Player.transform.position, _BehaviorTree.moveSpeed * Time.deltaTime);
            curState = Results.RUNNING;
        }

        if (Vector3.Distance(_BehaviorTree.Player.transform.position, _BehaviorTree.transform.position) > 10f)
        {
            curState = Results.FAILED;
        }
        */
    }
}
