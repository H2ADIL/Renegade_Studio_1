using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase_State : Node
{
    //bool move = true;

    public override void Execute()
    {
        curState = Results.RUNNING;

        List<Vector3> Pathfinder = PathfindingManager._instance.GetPath(_BehaviorTree.transform.position, _BehaviorTree.Player.transform.position);
        int targetIndex = 1;
        if (Pathfinder.Count > 2)
        {
            Vector3 dir = Pathfinder[2] - _BehaviorTree.transform.position;
            if (!Physics.Raycast(_BehaviorTree.transform.position, dir, dir.magnitude))
            {
                targetIndex = 2;
            }
        }
        _BehaviorTree.transform.position = Vector3.MoveTowards(_BehaviorTree.transform.position, Pathfinder[targetIndex], _BehaviorTree.speed);
   

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
