using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//RobotBehavior is inheriting from Robot class because the Robotclass has the bool values of the states which are also used as a check to proceed in the tree
public class RobotBehavior : Robot {

	//need to initialise tree here , working on action nodes currently so tree not initialised yet.
	//created reference to this script in the Node abstract class as nodes action nodes need to refer to this script
	//inorder to change the booleans that I have created in primary RobotClass.

	// Use this for initialization
	void Start () {
		//tree will be initialised in void start.
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Sleeping);
		Debug.Log (Attacking);
		Debug.Log (Chasing);
		Debug.Log (Patrolling);
		Debug.Log (Searching);
	}
}
