using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_State : Node
{
    int curTargetIndex;
    bool isReverse;
    float timer;

    public override void Execute()
    {
        curState = Results.SUCCESS;
        _BehaviorTree.transform.position = Vector3.MoveTowards(_BehaviorTree.transform.position, _BehaviorTree.Nodes[curTargetIndex].transform.position, _BehaviorTree.speed);
        _BehaviorTree.transform.LookAt(_BehaviorTree.Nodes[curTargetIndex].transform.position);

        if (_BehaviorTree.transform.position == _BehaviorTree.Nodes[curTargetIndex].transform.position)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                //deciding the new target
                if (isReverse)
                    curTargetIndex--;
                else
                    curTargetIndex++;

                if (curTargetIndex < 0 || curTargetIndex >= _BehaviorTree.Nodes.Length)
                {
                    isReverse = !isReverse;
                    curTargetIndex = Mathf.Clamp(curTargetIndex,0, _BehaviorTree.Nodes.Length-1);
                }

                //resetting timer
                timer = _BehaviorTree.pauseDuration;
            }
        }
    }
}
