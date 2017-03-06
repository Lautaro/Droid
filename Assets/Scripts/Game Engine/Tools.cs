using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tools : MonoBehaviour
{



	/// <summary>
	/// Mouseclick in World Space	/// </summary>
	/// <returns>The mouse click world position.</returns>
	public static Vector2 GetMouseClickWorldPosition ()
	{
		var mouseClick = Input.mousePosition;
		mouseClick.z = ZoneScene.player.transform.position.z - ZoneScene.mainCamera.transform.position.z;

		var worldPoint = ZoneScene.mainCamera.ScreenToWorldPoint (mouseClick);

		Debug.DrawRay (worldPoint, new Vector3 (0, 0, 10), Color.white, 3f);
		return worldPoint;
	}

	public static List<GameObject> GetStuffAtMousePosition ()
	{

		Collider2D[] hits = Physics2D.OverlapCircleAll (GetMouseClickWorldPosition (), 0.1f);
		List<GameObject> go = new List <GameObject> ();
		foreach (var hit in hits) {
			 
			go.Add (hit.gameObject);
			print (hit.gameObject.name);
		}
		return go;
	}


	/// <summary>
	/// Gets the direction vector where looker points towards lookAt at the Z axis. 
	/// </summary>
	public static Vector3 RotateZTowards (Transform looker, Vector3 lookAt)
	{				
		var target = Quaternion.LookRotation ((Vector2)looker.position - (Vector2)lookAt, Vector3.forward);
		//Set to zero because we only care about z axis			
		target.x = 0.0f;
		target.y = 0.0f;	
		return target.eulerAngles;
	}

//		void Update ()
//		{
//				if (Input.GetMouseButtonDown (0)) {
//						GetStuffAtMousePosition ();
//				}
//		}
}
