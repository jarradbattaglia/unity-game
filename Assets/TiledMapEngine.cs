using UnityEngine;
using System.Collections;

public class TiledMapEngine : MonoBehaviour {

	// Use this for initialization

	GameObject grass;

	void Start () {

		int x = -1500;
		int y = -500;

		for (int i = 0; i < 25; i++) {

			for(int j = 0; j < 50; j++) {

				grass = (GameObject) Instantiate (Resources.Load ("grasstile"));
				placeTile(grass, new Vector2(x, y));
				x += 64;
			}
			x = -1500;
			y += 64;
		}

	}

	void placeTile(GameObject grass, Vector2 position) {

		grass.transform.position = new Vector2 (position.x / 100, position.y / 100);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
