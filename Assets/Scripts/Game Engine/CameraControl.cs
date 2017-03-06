using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{

	static Transform droid;
	float cameraZ;
	public float  multiplier ;

	// Use this for initialization
	void Start ()
	{
		cameraZ = transform.position.z;
		droid = ZoneScene.player.transform;
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{

		//Trying to do Forward Camera http://dev.yuanworks.com/2013/03/09/little-ninja-dev-smart-camera-movement/
	
//		var speed = droid.rigidbody2D.velocity.magnitude;
//		if (speed > 1) {
//			var maxSpeed = 30;
//			var percentageOfMaxSpeed = speed / maxSpeed;
//			if (percentageOfMaxSpeed > 1) {
//				percentageOfMaxSpeed = 1;
//			}
//
//			var maxMultiplier = 5.0f;
//			multiplier = percentageOfMaxSpeed * maxMultiplier;
//			multiplier = Mathf.Clamp (multiplier, 1, maxMultiplier);
//		
//		}


        //UNCOMMENT THIS FOR NORMAL FOLLOWPLAYER CAM
        //gameObject.iMoveUpdate ().X (droid.position.x * multiplier).Start ();
        //gameObject.iMoveUpdate ().Y (droid.position.y * multiplier).Start ();
	}
}
