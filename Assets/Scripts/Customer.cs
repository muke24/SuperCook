using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : CustomerManager
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = spawnPos.position;
        randomPath = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
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
        }
    }
}
