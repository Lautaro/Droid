using UnityEngine;
using System.Collections;


/// <summary>
/// Suicidal zombie moves towards target and calls Die() when reaching the it.
/// </summary>
public class SuicidalZombie : AbilityBase
{
		public Transform target;
		public float Speed = 1f;
		float timer;
		public CreatureBase creature;

		// Use this for initialization
		void Start ()
		{
				target = ZoneScene.player.transform;
				creature = GetComponent<CreatureBase> ();
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (target && creature.State != CreatureState.Dead) {
						
						
						if (timer < Time.time) {
				
								var direction = ((Vector2)target.position - (Vector2)transform.position).normalized;

								//Throw in some randomness to the direction
								direction.x += Random.Range (-0.5f, 0.5f);
								direction.y += Random.Range (-0.5f, 0.5f);
		
								Debug.DrawLine (transform.position, direction * 3, Color.cyan, 0.01f);

								rigidbody2D.AddForce (direction.normalized * Speed * 100);
								rigidbody2D.AddTorque (Random.Range (-200f, 200f));
								timer = Time.time + 1f;
								target = ZoneScene.player.transform;
						}	
				}
		}

		void OnCollisionEnter2D (Collision2D coll)
		{

				if (coll.gameObject.name == "Player" && creature.State != CreatureState.Dead) {
						creature.State = CreatureState.Dead;
						var player = coll.gameObject.GetComponent<TakeDamage> ();
						player.ProjectileHit (transform.position, 50, 500);

						SendMessage ("Die");

				}

		}

}
