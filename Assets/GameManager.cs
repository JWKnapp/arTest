using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	// public static GameManager instance = null;

	public GameObject victoryText;

	public void CompleteLevel () {
		victoryText.SetActive (true);

		EndGame ();
	}

	// public float resetDelay;

	// void Awake () {
	// 	if (instance == null)
	// 		instance = this;
	// 	else if (instance != null)
	// 		Destroy (gameObject);
	// }

	public void EndGame () {
		// display win message
		// victoryText.SetActive (true);

		if (gameHasEnded == false) {
			gameHasEnded = true;
		}
		// reset game
		Invoke ("Restart", restartDelay);

	}

	void Restart () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
}
