using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position.Set(target.transform.position.x, transform.position.y, transform.position.z);
	}
}
