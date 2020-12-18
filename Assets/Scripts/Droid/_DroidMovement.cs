using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DroidMovement : MonoBehaviour
{


		float  maxAcceleration ;
		public float MaxAcceleration {
				get {
						return maxAcceleration;
				}
				set {
						maxAcceleration = value;
						rotationSpeed = maxAcceleration * 0.03f;
				}
		}


		float closeDistanceAcceleration ;
		float acceleration = 0;
		bool rotateToTarget;
		bool travelToTarget = false;
		public bool brake = false;
		Vector3 target;
		float rotationSpeed ;
		Quaternion targetRotation;
		Droid droid;
		GameObject body;
		Animator animator;
		ParticleSystem dustEffect;
		ParticleSystem pebbleEffects;
		Camera mainCamera;
		public AudioClip DroidMoving;
		public AudioClip DroidHalt;

		void Awake ()
		{
				MaxAcceleration = 200f;
				closeDistanceAcceleration = 80;				
				body = transform.Find ("Body").gameObject;
				droid = GetComponent<Droid> ();
				animator = droid.GetComponent<Animator> ();
		
		
		}
		void Start ()
		{
				mainCamera = ZoneScene.mainCamera;
				dustEffect = transform.SearchRecursively ("DustParticles").GetComponent<ParticleSystem> ();
				pebbleEffects = dustEffect.transform.Find ("Pebbles").GetComponent<ParticleSystem> ();
		}






		// Update is called once per frame
		void FixedUpdate ()
		{		
				RotateTowardsTarget ();
				TravelToTarget ();	
		}

		public void SetTarget (Vector2 target)
		{
				this.target = target;
				rotateToTarget = true;
				travelToTarget = false;
				brake = false;
		
				Debug.DrawLine (mainCamera.transform.position, target, Color.red, 10f);	
		}

		void RotateTowardsTarget ()
		{
				if (rotateToTarget == true && target != null && brake == false) {

						targetRotation = Quaternion.LookRotation (droid.transform.position - target, Vector3.forward);
						//Set to zero because we only care about z axis			
						targetRotation.x = 0.0f;
						targetRotation.y = 0.0f;
						droid.transform.rotation = Quaternion.Slerp (body.transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
						if (AngleBetweenTargetAndPlayer () < 25) {
								//Rotation is almost complete and acceleration can take place. 				
								travelToTarget = true;

						}
						if (AngleBetweenTargetAndPlayer () < 1) {
								//Rotation is complete. Accelerate at full speed.  
								travelToTarget = true;
								rotateToTarget = false;
								droid.transform.rotation = targetRotation;
						}
						
						if (!GetComponent<AudioSource>().isPlaying) {
								
								GetComponent<AudioSource>().clip = DroidMoving;
								GetComponent<AudioSource>().loop = true;
								GetComponent<AudioSource>().Play ();
						}		
				}
		}

		void TravelToTarget ()
		{
				if (travelToTarget == true && !droid.IsHarvesting) {

					
						var distanceToTarget = Vector3.Distance (droid.transform.position, target);
						animator.speed = acceleration / maxAcceleration;
						animator.SetFloat ("Speed", acceleration / maxAcceleration);
												
					
						acceleration = maxAcceleration;

		

						if (distanceToTarget < 20) {

								acceleration = closeDistanceAcceleration; // maxAcceleration * (distanceToTarget / 25);
						}

						//Make sure never to acellerate harde than max
						if (acceleration > maxAcceleration) {
								acceleration = maxAcceleration;
						}

						

						if (brake) {
								if (IsTravelling ()) {
										//	print (string.Format ("BRAKE Acceleration {0}  -  Velocity {1}", -acceleration, player.rigidbody2D.velocity));
										droid.GetComponent<Rigidbody2D>().AddForce (droid.transform.up * -acceleration);
									
								} else {
										travelToTarget = false;			
										rotateToTarget = false;

								}
						} else {
								//print (string.Format ("Acceleration {0}  -  Velocity {1} - Distance {2}", acceleration, player.rigidbody2D.velocity, distanceToTarget));
								droid.GetComponent<Rigidbody2D>().AddForce (droid.transform.up * acceleration);	
																
						}

						if (distanceToTarget < 5) {
								
								rotateToTarget = false;
								travelToTarget = false;
								brake = true;
								acceleration = 0;
						}

						// HAST STOPPED
						if (!IsTravelling ()) {
											
								brake = false;
								travelToTarget = false;
						}
	

				} else {
						
						animator.SetFloat ("Speed", 0);	
						animator.speed = 1;
				}		

				if (!rotateToTarget && !travelToTarget && !IsTravelling () && GetComponent<AudioSource>().isPlaying) {			
						//SFX STOP
						GetComponent<AudioSource>().Stop ();
						GetComponent<AudioSource>().PlayOneShot (DroidHalt);
					
				}
				
				SetDustRate ();
		}



		void SetDustRate ()
		{								
				var dustStrength = acceleration * 10;

				dustEffect.Play (true);
				dustEffect.emissionRate = droid.GetComponent<Rigidbody2D>().velocity.magnitude * 8; //Adjust dust particles acording to speed
				pebbleEffects.emissionRate = droid.GetComponent<Rigidbody2D>().velocity.magnitude * 5;
				//	pebbleEffects.startSpeed = player.rigidbody2D.velocity.magnitude;
				if (droid.GetComponent<Rigidbody2D>().velocity.magnitude < 1) {
						dustEffect.Play (true);
				} 				
		}

		float AngleBetweenTargetAndPlayer ()
		{
				return Mathf.Abs (droid.transform.rotation.eulerAngles.z - targetRotation.eulerAngles.z);
		}

		bool IsTravelling ()
		{
				var xSpeed = Mathf.Abs (droid.GetComponent<Rigidbody2D>().velocity.x);
				var ySpeed = Mathf.Abs (droid.GetComponent<Rigidbody2D>().velocity.y);
				var speedLimig = 3f;
				if (ySpeed > speedLimig && xSpeed > speedLimig) {
									
					

						return true;
						
				} else {						
						return false;
				}
		}

}
