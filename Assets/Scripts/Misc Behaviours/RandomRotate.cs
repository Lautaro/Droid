using UnityEngine;
using System.Collections;

public class RandomRotate : MonoBehaviour
{
		Quaternion target;

		public	float minSpeed = 0.02f;
		public	float maxSpeed = 0.2f;
		public	float speed = 0.1f;
		public float range = 100;
		public float timerRange = 3f;
		public bool rotateX;
		public bool rotateY;
		public bool rotateZ;
		float endTime; 

		
		// Update is called once per frame
		void Update ()
		{
				transform.rotation = Quaternion.Slerp (transform.rotation, target, Time.deltaTime * speed);
				var zRot = transform.rotation.eulerAngles.z; 
				var targetZror = target.eulerAngles.z;
				if (endTime < Time.time) {
						SetRandomTarget ();
				}					

		}



		void SetRandomTarget ()
		{
				var x = 0f;
				var y = 0f;
				var z = 0f;

				if (rotateX) {
						x = target.eulerAngles.x + Random.Range (-range, range);
				}

				if (rotateY) {
						y = target.eulerAngles.y + Random.Range (-range, range);
				}

				if (rotateZ) {
						z = target.eulerAngles.z + Random.Range (-range, range);
				}

				speed = Random.Range (minSpeed, maxSpeed);
				target = Quaternion.Euler (x, y, z);	
				
				endTime = Time.time + Random.Range (0, timerRange);
				
		}
}
