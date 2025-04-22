using UnityEngine;
using Pathfinding;
using UnityEngine.AI;

public class NpcAI : MonoBehaviour
{
    public Vector2 target;
    public float speed = 200f, nextWaypointDistance = 3f;

    [SerializeField]Vector2 minPosition, maxPosition;

    public Transform npcGFX;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone())
        {
            seeker.StartPath(rb.position, target, OnPathComplete);
            SetRandomTarget();
        }
                    
    }
    void SetRandomTarget()
    {
        Vector2 target = new Vector2(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y));
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (path == null)
            return;

        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }else
         { 
            reachedEndOfPath = false;
         }
        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position);
        Vector2 force = (direction * speed * Time.deltaTime).normalized;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if (distance < nextWaypointDistance)
            currentWaypoint++;

        if (force.x >= 0.01f)
            npcGFX.localScale = new Vector3(1, 1, 1);
        else if (force.x <= -0.01f)
            npcGFX.localScale = new Vector3(-1, 1, 1);
    }

}
