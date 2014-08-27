using UnityEngine;
using System.Collections;

public class TouchBehaviour : MonoBehaviour {

	private Vector2 touch;

	// Use this for initialization
	void Start () {
		Input.multiTouchEnabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var T in Input.touches) {
			if(T.phase == TouchPhase.Moved){
				transform.position = T.position;
			}
		}
	}
}
