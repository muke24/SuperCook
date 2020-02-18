using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text gameTimeText;
	public float gameTime = 60.0f;

	void Update()
	{
		gameTimeText.text = "Time " + gameTime.ToString();

		if (gameTime > 0f)
		{
			gameTime -= Time.deltaTime;
		}

		if (gameTime < 0f)
		{
			gameTime = 0f;
		}

	}
}
