using UnityEngine;
using System.Collections;

public class TestPlayerController : MonoBehaviour
{
		GameObject platform;
		bool moveForward;
		public	int targetRotation;
		float speed = 1f;
		// Use this for initialization
		void Start ()
		{
				platform = transform.Find ("Platform").gameObject;
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (Input.GetKey (KeyCode.Space)) {
			
						transform.Translate (Vector3.up * 0.01f);
				} 

//				if (Input.GetKey (KeyCode.W)) {
//						if (Input.GetKey (KeyCode.A)) {
//				
//								//UP LEFT
//								targetRotation = 45;
//
//						} else 
//						if (Input.GetKey (KeyCode.D)) {
//								//UP RIGHT
//								targetRotation = -45;
//						} else { 
//
//								//UP
//								targetRotation = 0;
//						}
//
//						moveForward = true;
//
//				} else
//
//				if (Input.GetKey (KeyCode.A)) {
//						//LEFT
//						moveForward = true;
//						targetRotation = 90;
//		
//				} else
//				if (Input.GetKey (KeyCode.S)) {
//					
//						if (Input.GetKey (KeyCode.A)) {
//				
//								//DOWN LEFT
//								targetRotation = 45;
//				
//						} else 
//						if (Input.GetKey (KeyCode.D)) {
//								//DOWN RIGHT
//								targetRotation = -135;
//						} else {
//								//DOWN LEFT
//								targetRotation = 180;
//						}
//						moveForward = true;
//				
//				} else
//
//				if (Input.GetKey (KeyCode.D)) {
//						//RIGHT
//						moveForward = true;
//						targetRotation = -90;
//				} else {
//						moveForward = false;
//				}

				if (moveForward) {
						print (targetRotation);

						//		gameObject.iRotateUpdate ().Rotation (new Vector3 (0, 0, 45)).Start ();

				}


	
		}

		
}
