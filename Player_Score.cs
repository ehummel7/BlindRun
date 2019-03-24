using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

	private float timeLeft = 31;
	public GameObject timeLeftUI;

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		timeLeftUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)timeLeft);

		if (timeLeft < 0.1f)
		{
			SceneManager.LoadScene("GameOver");
		}
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{
		if(trigger.gameObject.name == "Barrier_Right")
		{
			SceneManager.LoadScene("Victory");
		}
	}
}
