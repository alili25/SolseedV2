using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] points;

    private int i;

    void Start()
    {
        transform.position = points[0].position;
    }

    void Update()
    {
        // Move platform toward current target point
        transform.position = Vector2.MoveTowards(
            transform.position,
            points[i].position,
            speed * Time.deltaTime
        );

        // When close enough, switch to next point
        if (Vector2.Distance(transform.position, points[i].position) < 0.01f)
        {
            i++;

            if (i == points.Length)
                i = 0;
        }
    }
}