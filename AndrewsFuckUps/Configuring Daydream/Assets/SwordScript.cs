using UnityEngine;
using System.Collections;

public class SwordScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("Collided");
		if (other.gameObject.CompareTag("stinger")) {
			other.gameObject.SetActive (false);
		}
	}
}
