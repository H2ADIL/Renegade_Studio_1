using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : CompositeNode
{
    //CHECKS, IN PRIORITY, EVERY CHILDREN
    //IF ONE HAS SUCCEEDED, SELECTOR = SUCCESS

    public override void Execute()
    {
        for (int i = 0; i < children.Count; i++)
        {
            children[i].Execute();

            if (children[i].curState == Results.SUCCESS)
            {
                curState = Results.SUCCESS;
                return;
            }
            if (children[i].curState == Results.RUNNING)
            {
                curState = Results.RUNNING;
                return;
            }
        }
        curState = Results.FAILED;

        Debug.Log("SELECTOR " + curState);
    }
}
