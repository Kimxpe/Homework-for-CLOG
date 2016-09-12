using UnityEngine;
using System.Collections;

public class trapdoorSwitch2 : MonoBehaviour {
	float rotationSpeed = -2;

	void Start () {
	}

	void Update () {
		if (Input.GetKey(KeyCode.R)) {
			print ("Welcome to the entrance of the cemetery of your lover...");
			transform.Rotate (Vector3.up * -rotationSpeed);
		}
	}
}
