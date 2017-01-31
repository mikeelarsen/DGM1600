using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			gameObject.transform.Translate (-.1f, 0, 0);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			gameObject.transform.Translate (.1f, 0, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			gameObject.transform.Translate (0, .1f, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			gameObject.transform.Translate (0, -.1f, 0);
		}

		if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.Translate (0, 0, .1f);
		}

		if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.Translate (0, 0, -.1f);
		}			 


	
	}
}
