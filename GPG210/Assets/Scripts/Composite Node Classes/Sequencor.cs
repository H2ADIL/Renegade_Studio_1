using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sequencor : CompositeNode
{
    //CHECKS ALL CHILDREN
    //IF ALL CHILDREN HAVE SUCCEEDED, SEQUENCOR = SUCCESS

    public override void Execute()
    {
        //Check all children
        //If one is success, class is success

        for (int i = 0; i < children.Count; i++)
        {
            children[i].Execute();

            if (children[i].curState == Results.FAILED)
            {
                curState = Results.FAILED;
                return;
            }
            if (children[i].curState == Results.RUNNING)
            {
                curState = Results.RUNNING;
                return;
            }
        }
        curState = Results.SUCCESS;

        Debug.Log("SEQUENCOR " + curState);
    }
}
