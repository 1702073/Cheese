using UnityEngine;
using Pathfinding;
using System.Collections;

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

    public float pauseDuration = 2f; // How long until npc will move after reaching the target
    private bool isPaused = false; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone() && ! isPaused)
        {
            seeker.StartPath(rb.position, target, OnPathComplete);
        }
    }
    void SetRandomTarget()
    {
        target = new Vector2(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y));
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
        if (path == null || isPaused)
            return; // If theis no path than npc's wont move

        if(currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            StartCoroutine(PausedMovement()); 
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

    IEnumerator PausedMovement()
    {
        isPaused = true;
        rb.linearVelocity = Vector2.zero; // Halt
        yield return new WaitForSeconds(pauseDuration);
        SetRandomTarget();
        isPaused = false;
        InvokeRepeating("UpdatePath", 0f, .5f);
    }
}
