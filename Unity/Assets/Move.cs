using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float moveSpeed = 10f;
	public float turnSpeed = 100f;
	public float yAxisSpeed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool forward = Input.GetKey (KeyCode.W);
		bool left = Input.GetKey (KeyCode.A);
		bool backward = Input.GetKey (KeyCode.S);
		bool right = Input.GetKey (KeyCode.D);

		bool up = Input.GetKey (KeyCode.Q);
		bool down = Input.GetKey (KeyCode.Z);

		if (forward) 
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (backward)
		{
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (left)
		{
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);
		}

		if (right) 
		{
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
		}

		if (up) 
		{
			transform.Translate (-Vector3.down * yAxisSpeed * Time.deltaTime);
		}

		if (down) 
		{
			transform.Translate (Vector3.down * yAxisSpeed * Time.deltaTime);
		}
	}
}
