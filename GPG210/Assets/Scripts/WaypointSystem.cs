using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointSystem : MonoBehaviour
{
    public Patrol _Patrol;
    private int currentPositionIndex = 0;
    public float speed;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.MoveTowards(transform.position, Patrol.Points[currentPositionIndex], speed);
        transform.LookAt(Patrol.Points[currentPositionIndex]);
        if (transform.position == Patrol.Points[currentPositionIndex])
        {
            currentPositionIndex++;
            if (currentPositionIndex >= Patrol.Points.Length)
            {
                currentPositionIndex = 0;
                return;
            }
        }
	}
}
