using UnityEngine;
using System.Collections;

public class CylinderScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(1,0,0), 10*Time.deltaTime);
	}
}
