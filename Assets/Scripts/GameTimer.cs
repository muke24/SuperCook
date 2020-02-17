using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
	private IEnumerator coroutine;

	void Start()
	{
		coroutine = GameTime(240.0f);
		StartCoroutine(coroutine);
	}

	private IEnumerator GameTime(float waitTime)
	{
		while (true)
		{
			yield return new WaitForSeconds(waitTime);
			print("Game timer started " + Time.time);
		}
	}

	void Update()
	{
		if (coroutine == GameTime(0.0f))
		{

			
		}
	}
}
