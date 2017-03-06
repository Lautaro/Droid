using UnityEngine;
using System.Collections;

public class DroidKeyboardMovement : MonoBehaviour
{
		//	GameObject body;
		bool moveForward ;
		int targetRotation;
		float acceleration = 100f;

		// Use this for initialization
		void Start ()
		{
				//			body = transform.Find ("Cylinder").gameObject;
	
		}
	
		// Update is called once per frame
		void FixedUpdate ()
		{

				if (Input.GetKey (KeyCode.W)) {
						if (Input.GetKey (KeyCode.A)) {
				
								//UP LEFT
								targetRotation = 45;
				
						} else 
						if (Input.GetKey (KeyCode.D)) {
								//UP RIGHT
								targetRotation = -45;
						} else { 
				
								//UP
								targetRotation = 0;
						}
			
						moveForward = true;
			
				} else
			
				if (Input.GetKey (KeyCode.A)) {
						//LEFT
						moveForward = true;
						targetRotation = 90;
			
				} else
				if (Input.GetKey (KeyCode.S)) {
			
						if (Input.GetKey (KeyCode.A)) {
				
								//DOWN LEFT
								targetRotation = 135;
				
						} else 
						if (Input.GetKey (KeyCode.D)) {
								//DOWN RIGHT
								targetRotation = -135;
						} else {
								//DOWN LEFT
								targetRotation = 180;
						}
						moveForward = true;
			
				} else
			
				if (Input.GetKey (KeyCode.D)) {
						//RIGHT
						moveForward = true;
						targetRotation = -90;
				} else {
						moveForward = false;
				}

//				if (Input.GetMouseButton (0)) {
//
//						//Gets the rotation vector towards the mouse
//						var target = Tools.RotateZTowards (transform, Tools.GetMouseClickWorldPosition ());
//
//						//Rotate to face mouse
//						gameObject.iRotateTo ().Rotation (target).Speed (50).Start ();
//				}

				//ROTATE AND MOVE FOPWARD
				if (moveForward) {
						print (targetRotation);
						//gameObject.iRotateUpdate ().Rotation (new Vector3 (0, 0, targetRotation)).Time (5).Start ();
						gameObject.iRotateTo ().Rotation (new Vector3 (0, 0, targetRotation)).Speed (50).Start ();
						rigidbody2D.AddForce (transform.up * acceleration);	
						
				}
		}
}
