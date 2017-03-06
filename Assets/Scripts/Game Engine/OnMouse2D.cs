using UnityEngine;
using System.Collections;

public class OnMouse2D : MonoBehaviour
{
		bool wasOver = false;
		[HideInInspector]
		void FixedUpdate ()
		{
				RaycastHit2D hit = Physics2D.Raycast (Camera.main.transform.position, Camera.main.ScreenToWorldPoint (Input.mousePosition));
				
				if (hit != false && hit.transform.gameObject == this.gameObject) {

						if (Input.GetMouseButtonDown (0)) {					
						 
								this.SendMessage ("OnMouseButtonDown2D", SendMessageOptions.DontRequireReceiver);		
						}
	
						if (Input.GetMouseButton (0)) {
								this.SendMessage ("OnMouseButton2D", SendMessageOptions.DontRequireReceiver);
						
		
						}

						if (Input.GetMouseButtonUp (0)) {
								this.SendMessage ("OnMouseButtonUp2D", SendMessageOptions.DontRequireReceiver);
						
						}			
				
						if (!wasOver) {
								this.SendMessage ("OnMouseEnter2D", SendMessageOptions.DontRequireReceiver);
						} else {
								this.SendMessage ("OnMouseOver2D", SendMessageOptions.DontRequireReceiver);
						}
						wasOver = true;

				} else {
						if (wasOver) {
								this.SendMessage ("OnMouseExit2D", SendMessageOptions.DontRequireReceiver);
						}
						wasOver = false;
				}
		}
}

