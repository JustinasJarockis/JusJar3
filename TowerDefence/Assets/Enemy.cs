using System.Collections;

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private int wavepointIndex = 0;
    void Start()
    {
        target = Waypoints.points[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed*Time.deltaTime, Space.World);
<<<<<<< HEAD
        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
=======
        if (Vector3.Distance(transform.position, target.position) <= 0.1f)
>>>>>>> 4274a2fe5605006a1c2a27df936105d694ea1e99
        {
            GetNextWayPoint();
        }
    }
<<<<<<< HEAD
=======
    //123
>>>>>>> 4274a2fe5605006a1c2a27df936105d694ea1e99
    void GetNextWayPoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject);
<<<<<<< HEAD
            return;
=======
>>>>>>> 4274a2fe5605006a1c2a27df936105d694ea1e99
        }
        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
}