using UnityEngine;
using System.Collections;

public class Player_WorldMap : MonoBehaviour
{
		Vector2 targetPosition ; 

		void Awake ()
		{
				targetPosition = transform.position;
				WorldMapScene.player = this;
		}

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				

		}


		public void GoToPosition (Vector2 selectedPosition)
		{
				var x = Mathf.Floor (selectedPosition.x) + 0.5f; 
				var y = Mathf.Floor (selectedPosition.y) - 0.5f;
				var z = -0.5f; 

				var newPos = new Vector3 (x, y, z);				

				transform.position = newPos;
		}
}
