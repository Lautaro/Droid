using UnityEngine;
using System.Collections;


/// <summary>
/// Projectiles are prefabs which can be thrown at targets and will interact on impact. 
/// </summary>
public class ProjectileBase : MonoBehaviour
{
		/// <summary>
		/// A mortar projectile is thrown in the air and does not impact on the way to its target since it goes in a high arc. 
		/// </summary>
		public bool IsMortar;
		public float Damage;
		public TakeDamage owner; 
		public float LifeSpan = 2f;

		// Use this for initialization
		void Awake ()
		{
				Invoke ("OnLifeSpanUp", LifeSpan);
		}
	
		virtual protected void OnCollisionEnter2D (Collision2D coll)
		{
				if (coll.gameObject.tag == "Creature" && coll.gameObject.tag == "Player") {
						var creature = coll.gameObject.GetComponent<TakeDamage> ();
						if (creature.gameObject != owner.gameObject) {
										
								creature.ProjectileHit (transform.position, Damage, 800);
								OnHit ();
						} else {
								//	print ("I wont hit my owner");
						}
				}		
		}


		/// <summary>
		/// Raised when life span is finished.  
		/// </summary>
		virtual protected void OnLifeSpanUp ()
		{			
				Die ();
		}


		/// <summary>
		/// Projectiles explodes and dies.
		/// </summary>
		virtual protected void Die ()
		{
				Destroy (gameObject, 1f);
		}

		/// <summary>
		/// Raised when projectiles hits a target. 
		/// </summary>
		virtual protected void OnHit ()
		{
				Die ();				
		}
}
