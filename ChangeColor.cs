using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) { 
			GetComponent<Renderer> ().material.color = Color.red; 
		} 
		if (Input.GetKeyDown (KeyCode.G)) { 
			GetComponenet<Renderer> ().material.color = Color.green; 
		}

		if (Input.GetKeyDown (KeyCode.B)) { 
			GetComponenet<Renderer> ().material.color = Color.blue; 
		}

		if (Input.GetKeyDown (KeyCode.Escape)) { 
			GetComponenet<Renderer> ().material.color = Color.yellow; 
		}

		if (Input.GetKeyDown (KeyCode.Space)) { 
			GetComponenet<Renderer> ().material.color = Color.black; 
		}

		if (Input.GetKeyDown (KeyCode.Delete)) { 
			GetComponenet<Renderer> ().material.color = Color.white; 
		}
	
	}
}
