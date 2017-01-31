using UnityEngine;
using System.Collections;

public class RotateBucks : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range (0.2f, 4.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(15, 30, 45) * Time.deltaTime * speed);
	
	}
}
