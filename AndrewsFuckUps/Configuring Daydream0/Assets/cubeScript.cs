using UnityEngine;
using System.Collections;

public class cubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void moveUp () {
		transform.position = transform.position + new Vector3 (1, 0, 0);
	}
}
