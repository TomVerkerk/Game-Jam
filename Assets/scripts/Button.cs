using UnityEngine;
using System.Collections;
	
	public class Button : MonoBehaviour {
		
		void OnGUI () {
			if (GUI.Button (new Rect (25, 25, 100, 30), "Button")) {
			audio.Play();
			}
		}
		
	}
