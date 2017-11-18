using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindingManager : MonoBehaviour
{
    //SINGLETON for Pathfinding is different to GameManager SINGLETONs
    //The case for the Singleton will change
    public static PathfindingManager _instance;

    void Awake()
    {
        _instance = this;
        isInitialized = false;
        Initialize();
    }

    //Nodes stores the position of each node
    Vector3[] NodesPositions;

    //Distances stores the lengths between each node
    float[][] Distances;
    public bool isInitialized;

    // Use this for initialization
    void Initialize()
    {
        NodesPositions = new Vector3[transform.childCount];
        Distances = new float[transform.childCount][];
        for (int i = 0; i < transform.childCount; i++)
        {
            NodesPositions[i] = transform.GetChild(i).position;
            Distances[i] = new float[transform.childCount];
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.childCount; i++)
            {
                if (i == j)
                {
                    Distances[i][j] = -1;
                }
                else
                {
                    Vector3 dir = NodesPositions[j] - NodesPositions[i];
                    if (!Physics.Raycast(NodesPositions[i], dir, dir.magnitude))
                    {
                        
                    }
                    else
                    {
                        Distances[i][j] = -1;
                    }
                }
            }
        }
    }

    public List<Vector3> GetPath(Vector3 start, Vector3 target)
    {
        float shortestDistance = float.MaxValue;
        int startNode = 0;
        int targetNode = 0;

        for (int i = 0; i < NodesPositions.Length; i++)
        {
            if (Vector3.Distance(start, NodesPositions[i]) < shortestDistance)
            {
                shortestDistance = Vector3.Distance(start, NodesPositions[i]);
                startNode = i;
            }
        }

        for (int i = 0; i < NodesPositions.Length; i++)
        {
            if (Vector3.Distance(target, NodesPositions[i]) < shortestDistance)
            {
                shortestDistance = Vector3.Distance(target, NodesPositions[i]);
            }
        }


        //DIJKSTRA ALGORITHM
        Queue<int> waitingList = new Queue<int>();  //Queue List to check each nodes within the graph
        float[] AccShortestDist = new float[NodesPositions.Length]; //TOTAL accumulated shortest distance from the start node to target node
        bool[] isVisited = new bool[NodesPositions.Length]; //Checks if the node has been visited or not
        int[] fromNode = new int[NodesPositions.Length]; //Keeps track of which node did the algorithm take go get to TargetNode

        //Initialize variables to default state
        for (int i = 0; i < NodesPositions.Length; i++)
        {
            AccShortestDist[i] = float.MaxValue;
            isVisited[i] = false;
            fromNode[i] = -1;
        }
        AccShortestDist[startNode] = 0;
        waitingList.Enqueue(startNode);

        //MAIN ALGORITHM LOOP
        while (waitingList.Count != 0)
        {
            int curNode = waitingList.Dequeue();
            for (int c = 0; c < NodesPositions.Length; c++)
            {
                //Checks every cell of the graph for connection and if node !isVisited[c]
                if (Distances[curNode][c] != 1 && !isVisited[c])
                {
                    waitingList.Enqueue(c);
                    if (AccShortestDist[curNode] + Distances[curNode][c] < AccShortestDist[c])
                    {
                        AccShortestDist[c] = AccShortestDist[curNode] + Distances[curNode][c];
                        fromNode[c] = curNode;
                    }
                }
            }
            isVisited[curNode] = true;
        }


        //BACKTRACKING
        int tNode = targetNode;
        List<Vector3> path = new List<Vector3>();

        path.Add(NodesPositions[targetNode]);
        while (tNode != startNode)
        {
            tNode = fromNode[tNode];
            path.Add(NodesPositions[tNode]);
        }
        path.Add(NodesPositions[startNode]);
        path.Reverse();
        return path;
    }

    //Allows lines to be drawn between nodes
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        for (int i = 0; i < NodesPositions.Length; i ++)
        {
            for (int j = 0; j < NodesPositions.Length; j++)
            {
                if (Distances[i][j] != -1)
                {
                    Gizmos.DrawLine(NodesPositions[i], NodesPositions[j]);
                }
            }
        }
    }
}
