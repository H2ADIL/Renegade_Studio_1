using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    //Node class for behavior tree
    public enum Results {SUCCESS, RUNNING, FAILED, READY}; //Stores the variables for results

    public List<Node> children = new List<Node>();

    public BehaviorTree _BehaviorTree;

    public Results curState = Results.READY;

    public void Initialization()
    {
        for (int i = 0; i < children.Count; i++)
        {
            children[i]._BehaviorTree = _BehaviorTree;
            children[i].Initialization();
        }

        if (curState == Results.READY)
        {
            Debug.Log("Behavior READY");
        }
    }

    public virtual void Execute()
    {
        Debug.Log("EXECUTE ORDER 66");
    }
}