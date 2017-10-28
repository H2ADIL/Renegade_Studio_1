using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public static Vector3[] Points;

    // Use this for initialization
    void Awake()
    {
        Points = new Vector3[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Points[i] = transform.GetChild(i).position;
        }
    }
}
