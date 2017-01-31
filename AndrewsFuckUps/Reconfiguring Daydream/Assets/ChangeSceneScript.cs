using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeText(){
		gameObject.GetComponentInChildren<Text>().text = "YO";
	}
}
