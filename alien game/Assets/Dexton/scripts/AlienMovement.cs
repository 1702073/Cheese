using UnityEngine;
using Pathfinding;
using System.Collections;

public class AlienMovement : MonoBehaviour
{
    public Vector2 target;
    public float speed = 200f, nextWaypointDistance = 3f;

    [SerializeField] Vector2 minPosition, maxPosition;

    public Transform npcGFX;

    //int coolDown = 0;

    Path path;
    int currentWaypoint = 0;
    bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    private bool isPaused = false;
    public double pauseDuration; // How long until npc will move after reaching the target

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pauseDuration = Random.Range(0.2f, 2.5f);
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        InvokeRepeating("UpdatePath", 0f, .5f);
    }

    void UpdatePath()
    {
        if (seeker.IsDone() && !isPaused)
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

        if (currentWaypoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            StartCoroutine(PausedMovement());
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position);
        Vector2 force = (direction * speed * Time.deltaTime);

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
        pauseDuration = Random.Range(0.2f, 2.5f); // Randomize the pause duration
        yield return new WaitForSeconds((float)pauseDuration);
        SetRandomTarget();
        isPaused = false;
        InvokeRepeating("UpdatePath", 0f, .5f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(new Vector3((minPosition.x + maxPosition.x) / 2, (minPosition.y + maxPosition.y) / 2, 0), new Vector3(maxPosition.x - minPosition.x, maxPosition.y - minPosition.y, 0));
    }
}