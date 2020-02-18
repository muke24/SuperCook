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

	private Vector3 spawnPos = new Vector3(-29f, 1f, 0f);
	private WayPoints wayPoints;

	// Start is called before the first frame update
	void Start()
	{
		customer.position = spawnPos;
		wayPoints = FindObjectOfType<WayPoints>();
		randomPath = Random.Range(1, 5);
	}

	// Update is called once per frame
	void Update()
	{
		agent.SetDestination(wayPoints.wayPointPositions[randomPath].position);
	}
}
