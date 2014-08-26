using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Randomize : MonoBehaviour {
	//publics
	public int pointAmount = 10;

	//privates
	private List<GameObject> points = new List<GameObject>();
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < pointAmount; i++) {
			GameObject point;
			Vector3 pos = UpdateLocation(-2.0f, 2.0f, -4.5f, 4.5f);

			for (int j = 0; j < points.Count; j++) {
				if (points[j].transform.position == pos) {
					pos = UpdateLocation(-2.0f, 2.0f, -4.5f, 4.5f);
					break;
				}
			}

			point = (GameObject)Instantiate(Resources.Load("Prefabs/Point"), pos, Quaternion.identity);

			points.Add(point);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private Vector2 UpdateLocation (float minX, float maxX, float minY, float maxY) {
		Vector2 pos = new Vector2(0, 0);

		pos.x = Random.Range(minX, maxX);
		pos.y = Random.Range(minY, maxY);

		return pos;
	}
}