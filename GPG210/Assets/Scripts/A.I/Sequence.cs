using UnityEngine;
using System.Collections;

public class Sequence : Node {

	public override void NodeAction() // this is the action of the Sequence node.
	{
		foreach (Node node in ChildNodesList) //we are using a foreach function to call the actions of each of the nodes that are in the childnodes list of the sequence , and based on their nodestate we will determine whether the sequence has failed or succeeded.
		{
			node.NodeAction(); //calling the action of the child of the sequence
			if (node.HasFailed()) //using the boolean function to check if the state of the child node is success or not , this in turn returns a bool value of true or false which we will use to determine what state to set for the sequence.
			{
				Failed();
				return; //if the child node has failed , the entire sequence will fail thus we return the function here and do not proceed further.
			}

			else if (node.isRunning())
			{
				Running();
				return; //if the child node is running , the sequence state will be set to running and thus we 'return' to not proceed further with the function.
			}
		}

		Success(); //if the states are not failure or running , then automatically it means that the sequence is a success as there are no other states that it can be in.
		return;
	}

}