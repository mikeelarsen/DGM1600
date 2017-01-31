using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			gameObject.transform.Rotate (0, -.5f, 0);
		}

		if (Input.GetKey (KeyCode.E)) {
			gameObject.transform.Rotate (0, .5f, 0);
		}
	
	}
}
