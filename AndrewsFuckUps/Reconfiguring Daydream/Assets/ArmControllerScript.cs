using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArmControllerScript: MonoBehaviour {

	public GameObject armAndSword;
	public GameObject sword;
	public GameObject swordBase;
	public GameObject playerBody;
	public string axis;
	public float rotationSpeed = 400; 

	// Use this for initialization
	void Start () {
		sword.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		Quaternion ori = GvrController.Orientation;
		armAndSword.transform.localRotation = ori;
		swordBase.transform.LookAt (playerBody.transform, new Vector3 (0, 1, 0));
		if (axis == "x") {
			sword.transform.Rotate (new Vector3 (1, 0, 0), rotationSpeed * Time.deltaTime);
		} else if (axis == "y") {
			sword.transform.Rotate (new Vector3 (0, 1, 0), rotationSpeed * Time.deltaTime);
		}
	}


}

