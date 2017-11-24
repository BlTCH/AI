using UnityEngine;
using System.Collections;

public class FollowMouseRotation : MonoBehaviour {
	private Vector3 lookAngle = Vector3.zero;
	public float turnSpeed;

	void Start () {
		//Cursor.lockState = CursorLockMode.Locked;
	}


	void Update () {
		float x = Input.GetAxis ("Mouse X");
		float y = Input.GetAxis ("Mouse Y");

		lookAngle += new Vector3 (-y * turnSpeed, x * turnSpeed, 0f);

		transform.localRotation = Quaternion.Euler (lookAngle);
	}
}
