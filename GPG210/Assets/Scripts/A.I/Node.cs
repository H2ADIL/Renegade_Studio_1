using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public abstract class Node {

	public List<Node> ChildNodesList = new List<Node>(); // created a list for the childnodes , and since all the nodes created are inheriting from this class, they will all have their own list of childnodes , which will be used in tree traversal.


	public RobotBehavior ROB; // reference to robotbehavior script in order to change bool values of sleeping , patrolling etc..


	public enum NodeStates // created enum variable for NodeStates , as the nodes will be using these three values to determine what state they are in.
	{
		FAILURE, //Failure nodestate created first as all nodes should be in a state of Failure upon the instant of creation , otherwise the tree will not traverse completely through the nodes to perform the checks that determine the state.
		RUNNING,
		SUCCESS
	}

	NodeStates myNodeStates; //reference to access mynodestates.

	public virtual void NodeAction () //created a virtual void function for the ACTION that the nodes will carry out , this is left empty because it will be overridden by the action of the respective node calling it.
	{

	}

	public void AddChild(Node node) //created an ADDchild function with 'node' as the parameter , this function will be used to add children to the nodes in the script where the tree is created. Adding child to a node will determine the way the tree traversal happens.
	{
		node.ROB = ROB;//everytime addchild function is called, it sets the value of ROB for the node being added as child to be the same as the ROB that is created in THIS script.
		ChildNodesList.Add(node);
	}

	public void Success() //void function that changes the state of the node it is being called in , in this case it will change the node state to success.
	{
		this.myNodeStates = NodeStates.SUCCESS;
		Debug.Log (this.GetType ().ToString () + "success"); //Debugging the current node + success to record if the function is successfully being called or not.
	}

	public void Running()
	{
		this.myNodeStates = NodeStates.RUNNING; // void function that changes the state of the node it is being called in , in this case it will change the node state to running.
		Debug.Log (this.GetType ().ToString () + "running");
	}

	public void Failed()
	{
		this.myNodeStates = NodeStates.FAILURE;//void function that changes the state of the node it is being called in , in this case it will change the node state to failure.

		Debug.Log (this.GetType ().ToString () + "fail");
	}

	public bool HasSucceeded() //boolean function which will either return 'true' or 'false' based on the node's current state, this is used in the selector and sequence nodes as a CHECK to determine whether to proceed further or stop the traversal of the tree.
	{
		return this.myNodeStates.Equals (NodeStates.SUCCESS);
	}

	public bool isRunning()//based on the return(whether true or false) , we will call success() or failure() void functions in the selector or sequence to change the nodestate of the selector or sequence.
	{
		return this.myNodeStates.Equals (NodeStates.RUNNING);
	}

	public bool HasFailed()
	{
		return this.myNodeStates.Equals(NodeStates.FAILURE);
	}

}