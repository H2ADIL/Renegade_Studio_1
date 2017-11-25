using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTree : MonoBehaviour
{
    public GameObject Player;
    public float moveSpeed;
    

    public Transform[] Nodes;   //The Nodes the AI wll follow
    public int currentWaypoint; //Current position
    public float speed; //Speed the AI will follow
    public float pauseDuration; //Amount of time the AI will pause per node
    public float curTime;  //Variable for pauseDuration
    public int startingNode;
    public int reverseWaypoint;
    public bool reversePath = false;

    Node Tree;

    void Start()
    {
        Tree = new Selector();
        Tree.children.Add(new Sequencor());
        Tree.children.Add(new Patrol_State());
        Tree.children[0].children.Add(new Chase_State());
        Tree.children[0].children.Add(new Attack_State());

        Tree._BehaviorTree = this;
        Tree.Initialization();
       Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Tree.Execute();
    }
}