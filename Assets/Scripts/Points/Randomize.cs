using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

public class Randomize : MonoBehaviour {
	//publics
	public int pointAmount = 10;

	//privates
	private List<GameObject> points = new List<GameObject>();
	private float[] coordinateX;
	private float[] coordinateY;
	
	// Use this for initialization
	void Start () {
		coordinateX = new float[pointAmount];
		coordinateY = new float[pointAmount];

		for (int i = 0; i < pointAmount; i++) {
			GameObject point;
			Vector3 pos = UpdateLocation(-2.0f, 2.0f, -4.5f, 4.5f);
			//int k = 0;

			point = (GameObject)Instantiate(Resources.Load("Prefabs/Point"), pos, Quaternion.identity);

			for (int j = 0; j < pointAmount; ++j) {
				if (coordinateX[j] <= pos.x + 1.0f && coordinateX[j] >= pos.x - 1.0f &&
				    coordinateY[j] <= pos.y + 1.0f && coordinateY[j] >= pos.y - 1.0f) {
					//Color custom = new Color(j * 0.5f, j * 0.05f, 0.0f);

					pos = UpdateLocation(-2.0f, 2.0f, -4.5f, 4.5f);
					//point.gameObject.renderer.material.color = custom;
					//point.name = "number: " + i;

					j = 0;
				}
			}

			/*while (k < coordinateX.Length && coordinateX[k] <= pos.x + 1.0f && coordinateX[k] >= pos.x - 1.0f &&
			       k < coordinateY.Length && coordinateY[k] <= pos.y + 1.0f && coordinateY[k] >= pos.y - 1.0f) {
				Color custom = new Color(k * 0.5f, k * 0.05f, 0.0f);

				pos = UpdateLocation(-2.0f, 2.0f, -4.5f, 4.5f);
				point.gameObject.renderer.material.color = custom;
				point.name = "number: " + i;

				k++;
			}*/

			point.transform.position = pos;
			point.name = PointScript.pointName;
			coordinateX[i] = pos.x;
			coordinateY[i] = pos.y;

			points.Add(point);
		}
	}
	
	// Update is called once per frame
	void Update () {
		/*for (int i = 0; i < Input.touchCount) {
			if (Input.GetTouch(i).phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

				if (Physics.Raycast(ray)) {
					Debug.Log("Test");
				}
			}
		}*/
	}

	public static Vector2 UpdateLocation (float minX, float maxX, float minY, float maxY) {
		Vector2 pos = new Vector2(0, 0);

		pos.x = Random.Range(minX, maxX);
		pos.y = Random.Range(minY, maxY);

		return pos;
	}
}