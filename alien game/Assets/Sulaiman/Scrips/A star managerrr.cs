using UnityEngine;
using System.Collections.Generic;

public class Astarmanagerrr : MonoBehaviour
{
    public static Astarmanagerrr instance;

    private void Awake()
    {
        instance = this;
    }

    [System.Obsolete]
    public List<Node>  GeneratePath(Node start, Node end)
    {
        List<Node> openSet = new List<Node>();

        foreach (Node n in FindObjectsOfType<Node>())
        {
            n.gScore = float.MaxValue;
        }

        start.gScore = 0;
        start.hScore = Vector2.Distance(start.transform.position, end.transform.position);
        openSet.Add(start);

        while(openSet.Count > 0)
        {
            int lowestF = default;

            for(int i = 1; i < openSet.Count; i++)
            {
                if(openSet[i].FScore() < openSet[lowestF].FScore())
                {
                    lowestF = i;
                }
            }

            Node current = openSet[lowestF];
            openSet.Remove(current);

            if (current == end)
            {
                List<Node> path = new List<Node>();

                path.Insert(0, end);
            }
        }

        return null;
    }
}
