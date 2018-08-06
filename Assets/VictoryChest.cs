using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryChest : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter () {
		//Trigger win funct
		// if (other.gameObject.tag == "monster") {
		// 	gameManager.CompleteLevel ();
		// }

		// if (other.collider.tag == "monster") {
		// 	gameManager.CompleteLevel ();
		// }

		// if (other.collider.name == "Monster") {
		gameManager.CompleteLevel ();
		// }
	}
}
