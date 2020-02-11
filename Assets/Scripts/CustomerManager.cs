using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CustomerManager : MonoBehaviour
{
	public int randomPath;
	public int randomItem;
	public NavMeshAgent agent;
	public Transform spawnPos;
	public Transform path1;
	public Transform path2;
	public Transform path3;
	public Transform path4;
	public Transform path5;

	public Vector3 pos1;
	public Vector3 pos2;
	public Vector3 pos3;
	public Vector3 pos4;
	public Vector3 pos5;

	// Start is called before the first frame update
	void Start()
	{
		pos1 = path1.position;
		pos2 = path2.position;
		pos3 = path3.position;
		pos4 = path4.position;
		pos5 = path5.position;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
