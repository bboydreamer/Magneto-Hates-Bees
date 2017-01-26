using UnityEngine;
using System.Collections;

public class StingerScript : MonoBehaviour {

	// Use this for initialization
	public GameObject sword;
	public Transform playerTransform;
	public float speed = 0.001f;

	public GameObject stingerTeleportAnimation;
	public GameObject swordTeleportAnimation;

	//public GameObject frozenAnimation;


	private bool swordIsActive = false;
	private bool isFrozen = false;

	void Start() {

		//teleportStinger ();
	}
	void Update () {
		if (!isFrozen) {
			Debug.Log ("Moving");
			moveTowardsPlayer ();
		}
//		if (GvrController.ClickButtonDown) {
//			teleportStinger ();
//		}
	}

	void moveTowardsPlayer(){
		transform.LookAt (playerTransform, new Vector3(0,1,0));
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, playerTransform.position, step);
	}

	public void moveStinger(){
		if (isFrozen) {
			isFrozen = false;
		}
	}

	public void stopStinger(){
		if (!isFrozen) {
			isFrozen = true;
		}
	}
		
	public void downClickHandler(){
		if (!swordIsActive) {
			teleportStinger ();
			swordIsActive = true;
		}
	}
		

	public void teleportStinger(){
		stingerTeleportAnimation.GetComponent<ParticleSystem>().Play (); 
		gameObject.SetActive (false);
		swordTeleportAnimation.GetComponent<ParticleSystem> ().Play ();
		sword.SetActive (true);
	}
}
