using UnityEngine;
using System.Collections;

public class Draggable : MonoBehaviour {
	Vector2 startPos;
	SliderJoint2D myVerticalSlider;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}

	void addSliderJoint() {
		if (myVerticalSlider == null) {
			myVerticalSlider = gameObject.AddComponent<SliderJoint2D> () as SliderJoint2D;
			myVerticalSlider.angle = 90;
		}
	}


	void OnMouseUp() {
		addSliderJoint ();
		GetComponent<Rigidbody2D> ().gravityScale = 1;
	}

	void OnMouseDrag() {        
		// Convert mouse position to world position
		Vector2 p = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		
		// Keep it in a certain radius
		Vector2 dir = p - startPos;
		
		// Set the Position
		transform.position = startPos + dir;
	}
	
}
