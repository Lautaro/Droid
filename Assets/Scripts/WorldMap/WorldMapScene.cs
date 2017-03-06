using UnityEngine;
using System.Collections;

public class WorldMapScene : MonoBehaviour
{

	#region STATIC GLOBAL REFERENSES

		static public Player_WorldMap player; 

#endregion  


		// Use this for initialization
		void Start ()
		{
			
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				var camera = Camera.main;
				if (Input.GetMouseButtonDown (0)) {
						var mouseClick = Input.mousePosition;
						mouseClick.z = 0 - camera.transform.position.z;
			
						var target = camera.ScreenToWorldPoint (mouseClick);
			
						Debug.DrawLine (camera.transform.position, target, Color.red, 10f);
						print (string.Format ("MousePosition {2} - Camera: {0} - Target: {1}", camera.transform.position, target, mouseClick));
				}
	
		}
}
