using UnityEngine;
using System.Collections;

public class TrapdoorSwitch : MonoBehaviour {
	float rotationSpeed = -2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.E)) {
			print ("You're free to jump!");
			transform.Rotate (Vector3.right * -rotationSpeed);
		}
	}
}
