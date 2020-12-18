using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class WorldMap : MonoBehaviour
{
		public Transform cursor; 
		public Vector2 selectedPosition;
		public Vector2 SelectedPosition {
				get {
						return selectedPosition;
				}
				set {
						selectedPosition = value;
						print ("Selected position: " + value);
				}
		}

 

		// Use this for initialization
		void Start ()
		{
				InvokeRepeating ("SlowUpdate", 0, 0.1f);
		}

		void SlowUpdate ()
		{
			
		}
	
		// Update is called once per frame
		void Update ()
		{
				
	
		}


		void OnMouseOver ()
		{
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hitInfo; 
				var cursorControl = cursor.GetComponent<Cursor> ();
		
				if (GetComponent<Collider>().Raycast (ray, out hitInfo, Mathf.Infinity)) {
						var point = hitInfo.point;
						var cursorPos = new Vector2 (Mathf.Floor (point.x), Mathf.Floor (point.y) + 1);
			
						cursorControl.SetPosition (cursorPos);
						//print (cursorPos);				
			
						if (Input.GetMouseButtonDown (0)) {					
				
								cursorControl.Blip (cursorPos);
								SelectedPosition = cursorPos;
								WorldMapScene.player.GoToPosition (selectedPosition);
				
						}
				} 
				
		}
}
