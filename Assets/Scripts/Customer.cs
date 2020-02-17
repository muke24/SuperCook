using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Customer : MonoBehaviour
{
    public Transform customer;
    public int randomPath;
    public int randomItem;
    public NavMeshAgent agent;
    private Vector3 spawnPos = new Vector3(-29f,1f,0f);
    private Vector3 pos1 = new Vector3(-9f,1f,5f);
    private Vector3 pos2 = new Vector3(-9f, 1f, 2.5f);
    private Vector3 pos3 = new Vector3(-9f, 1f, 0f);
    private Vector3 pos4 = new Vector3(-9f, 1f, -2.5f);
    private Vector3 pos5 = new Vector3(-9f, 1f, -5f);


    private WayPoints wayPoints;


    // Start is called before the first frame update
    void Start()
    {
        wayPoints = FindObjectOfType<WayPoints>();
        //WherePosIsLocated.pos[];

        customer.position = spawnPos;
        randomPath = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(wayPoints.wayPointPositions[randomPath].position);
        //agent.SetDestination(pos[randomPath].position);
        /*
        if (randomPath == 0)
        {
            agent.SetDestination(spawnPos);
        }
        if (randomPath == 1)
        {
            agent.SetDestination(pos1);
        }
        if (randomPath == 2)
        {
            agent.SetDestination(pos2);
        }
        if (randomPath == 3)
        {
            agent.SetDestination(pos3);
        }
        if (randomPath == 4)
        {
            agent.SetDestination(pos4);
        }
        if (randomPath == 5)
        {
            agent.SetDestination(pos5);
        }*/
    }
}
