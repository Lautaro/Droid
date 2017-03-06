using UnityEngine;
using System.Collections;

public class DroidHead : MonoBehaviour
{


		//LOOK TOWARDS
		float rotationSpeed = 4f;
		Vector3 rotationTarget;
		GameObject head;
		bool doLookAtTarget;

		// Use this for initialization
		void Start ()
		{
				head = transform.SearchRecursively ("Head").gameObject;
				doLookAtTarget = true;
		}
	
		// Update is called once per frame
		void Update ()
		{				
		
				if (doLookAtTarget) {			
			
						rotationTarget = Camera.main.ScreenToWorldPoint (Input.mousePosition);						
			
						var _lookRotation = Quaternion.LookRotation (head.transform.position - rotationTarget, Vector3.forward);
			
						_lookRotation.x = 0.0f;
			
						_lookRotation.y = 0.0f;
			
						head.transform.rotation = Quaternion.Slerp (head.transform.rotation, _lookRotation, Time.deltaTime * rotationSpeed);			
				
				}

	
		}
}
