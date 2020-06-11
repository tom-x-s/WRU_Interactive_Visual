using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Rigidbody))]
public class npcver2 : MonoBehaviour
{
    NavMeshAgent nm;
    Rigidbody rb;
    public Transform Target;
    public Transform[] WayPoints;
    public int Cur_Waypoint;
    public float speed, stop_distance;
    public float PauseTimer;
    [SerializeField]
    private float cur_timer;

    // Start is called before the first frame update
    void Start()
    {
        nm = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;

        Target = WayPoints[Cur_Waypoint];
        cur_timer = PauseTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //settings updated
        nm.acceleration = speed;
        nm.stoppingDistance = stop_distance;

        float distance = Vector3.Distance(transform.position, Target.position);

        //Move to waypoint
        if (distance > stop_distance && WayPoints.Length >0)
        {
            //animator: set bool for moving = true
            //animator: set bool for idle = false
            //find waypoint
            Target = WayPoints[Cur_Waypoint];
        }
        else if(distance <= stop_distance && WayPoints.Length > 0)
        {
            if (cur_timer > 0)
            {
                cur_timer -= 0.01f;

                //animator: set bool for moving = false
                //set bool for idle = true
            }
            if (cur_timer <= 0)
            {
                Cur_Waypoint++;
                if (Cur_Waypoint >= WayPoints.Length)
                {
                    Cur_Waypoint = 0;
                }
                Target = WayPoints[Cur_Waypoint];
                cur_timer = PauseTimer;
            }
        }

        nm.SetDestination(Target.position);
    }

}
