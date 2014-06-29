using UnityEngine;
using System.Collections;

public class linkController : MonoBehaviour {

	public float moveSpeed;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 transformDirection = transform.position;

		if (Input.GetButton ("Fire1")) {
			Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			moveDirection = moveToward - transformDirection;
			moveDirection.z = 0;
			moveDirection.Normalize();
		}
	}
}
