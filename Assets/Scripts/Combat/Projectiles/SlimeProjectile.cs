using UnityEngine;
using System.Collections;

public class SlimeProjectile : ProjectileBase
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnCollisionEnter2D (Collision2D coll)
		{
				if (coll.gameObject.name == "Player") {
						var player = coll.gameObject.GetComponent<TakeDamage> ();
						player.ProjectileHit (transform.position, 50f, 1000);
						collider2D.enabled = false;
						Die ();
				
				}
		}

		protected override void OnLifeSpanUp ()
		{
				Die ();
				
		}

		protected override void Die ()
		{
				var go = this.GetPrefabInstance ("fx_SlimeExplosion");
				go.transform.parent = transform;
				go.transform.position = transform.position;
				var deathEffect = go.GetComponent<ParticleSystem> ();
				deathEffect.Play ();
				GetComponentInChildren<Renderer> ().enabled = false;
				
				var slimer = this.GetPrefabInstance ("crtr_SlimeStalker");
				slimer.transform.position = transform.position;
				Destroy (gameObject, 2f);

		}

	
}
