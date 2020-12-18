using UnityEngine;
using System.Collections;

public class MoveRandomly : AbilityBase
{

		public bool DoMoveRandomly;
		public bool IsMoving;
		float moveTimer;
		public float speed ;
		public	float minSpeed = 5f;
		public	float maxSpeed = 15f;
		public float MaxSecondsBetweenMoving;
		Animator animator;

		void Awake ()
		{
				animator = GetComponent<Animator> ();
		}

		// Update is called once per frame
		void Update ()
		{
				if (DoMoveRandomly && !IsMoving) {
						StartCoroutine (MoveRandomly_cr ());
				}
		}

		public  IEnumerator MoveRandomly_cr ()
		{
				IsMoving = true;
				print ("Now im moving randomly");
		
				if (animator) {
						animator.SetBool ("IsMoving", true);
				}		

				speed = Random.Range (minSpeed, maxSpeed);
		
				var pos = transform.position;
		
				//Returns a random position in Slimes local space. Since the circles center is the slimes position. 
				var targetLocalPosition = Random.insideUnitCircle * 10;


				//Transform the target to world space
				var targetPosition = transform.TransformPoint (targetLocalPosition);

				//	Keep position within screen
				targetPosition.x = Mathf.Clamp (targetPosition.x, -50, 50);			
				targetPosition.y = Mathf.Clamp (targetPosition.y, -50, 40);
				

				//Get the travel direction to go to the target and normalize it so it can be used with a speed multiplier
				var direction = ((Vector2)targetPosition - (Vector2)pos).normalized;

				//Calculate the distance to target
				var distance = Vector3.Distance (pos, targetPosition);

                print("Moing towards X/Y: " + targetPosition.x + "/" + targetPosition.x);
				while (distance > 2f) {
						Debug.DrawLine (pos, targetPosition, Color.cyan, 0.01f);
						
						pos = transform.position;			
						direction = ((Vector2)targetPosition - (Vector2)pos).normalized;						
						distance = Vector3.Distance (pos, targetPosition);
						GetComponent<Rigidbody2D>().AddForce (direction.normalized * speed);
						
						yield return null;			
				}

				print ("Reached destination");
				if (animator) {
						animator.SetBool ("IsMoving", false);
				}		
				IsMoving = false;
				DoMoveRandomly = false;
				var pauseTime = Random.Range (0, MaxSecondsBetweenMoving);
				yield return new WaitForSeconds (pauseTime);
				DoMoveRandomly = true;
								
		}

}
