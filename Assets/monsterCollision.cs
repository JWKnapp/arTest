using UnityEngine;

public class monsterCollision : MonoBehaviour {

	public CharacterController movement;

	void OnCollisionEnter (Collision collisionInfo) {
		if (collisionInfo.collider.tag == "wall") {
			movement.enabled = false;
		}

	}
}
