using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour {

	public GameObject robot;
	public GameObject Player;

	//these boolean values are affected by their respective leaf nodes , and are debug.logged in the robotbehavior to observe if any of the actions is true or not.
	public bool Sleeping = false;
	public bool Attacking = false;
	public bool Chasing = false;
	public bool Patrolling = false;
	public bool Searching = false;






	// Use this for initialization
	void Start () {
		/*
		Sleeping = false;
		Attacking = false;
		Chasing = false;
		Patrolling = false;
		Searching = false;
	*/

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
