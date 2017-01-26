using UnityEngine;
using System.Collections;

public class testingPanScript : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	void Start () {
		anim = GetComponent<Animator> ();
		anim.Play ("SwatPan");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
