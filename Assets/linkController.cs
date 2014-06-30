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

		float yvel = 0f;
		float xvel = 0f;
		
		if (Input.GetKey (KeyCode.W)) {
			yvel = 1f;
		}
		
		if (Input.GetKey (KeyCode.A)) {
			xvel = -1f;
		}
		
		if (Input.GetKey (KeyCode.S)) {
			yvel = -1f;
		}
		
		if (Input.GetKey (KeyCode.D)) {
			xvel = 1f;
		}
		
		if(!Input.GetKey(KeyCode.W) && 
		   !Input.GetKey (KeyCode.A) &&
		   !Input.GetKey (KeyCode.S) &&
		   !Input.GetKey (KeyCode.D)){
			
			xvel = 0f;
			yvel = 0f;
		}
		
		rigidbody2D.velocity = new Vector2 (xvel, yvel);

		Vector3 transformDirection = transform.position;
		
		if (Input.GetButton ("Fire1")) {
			Vector3 moveToward = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			moveDirection = moveToward - transformDirection;
			moveDirection.z = 0;
			moveDirection.Normalize();
		}
	}
}
