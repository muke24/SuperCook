using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
	public Camera cam;

	public GameObject player;

	public GameObject coffeeMachine;
	public GameObject colaMachine;

	public Image coffeeImage;
	public Image colaImage;

	public bool moveCoffee = false;
	public bool moveCola = false;

	public bool coffeeUsable = true;
	public bool colaUsable = true;

	void Update()
	{
		

		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				if (hit.transform.name == coffeeMachine.name && coffeeUsable == true)
				{
					moveCoffee = true;
				}
				else
				{
					moveCoffee = false;
				}
			}
			

		}

		if (moveCoffee == true && Vector3.Distance(player.transform.position, coffeeMachine.transform.position) < 2.5f)
		{
			coffeeUsable = false;
			moveCoffee = false;
		}
	}
}
