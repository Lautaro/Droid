

using UnityEngine;
using System.Collections;

/// <summary>
/// A simple weapon that hurls a projectile towards a target 
/// </summary>
public class ProjectileLauncher : WeaponsBase
{		
	public GameObject projectilePrefab; 

	void Awake ()
	{
		if (!projectilePrefab) {
		
			throw new UnityException ("The Projectile Launcher must have a projecttile prefab ");
		} else {
			var projectile = projectilePrefab.GetComponent<ProjectileBase> ();
			if (!projectile) {
			//	throw new UnityException ("The Projectile Launcher must have a projecttile prefab with a projectile base script ");
			}
		}
	}


	protected override void OnWeaponFired ()
	{
		GameObject projectile = this.GetPrefabInstance ("crtr_SlimeStalker", transform.position);
		//var projectileControl = projectile.GetComponent<ProjectileBase> ();
		//Physics2D.IgnoreCollision (projectile.collider2D, collider2D); //Perhaps implemented in the future?
		//projectileControl.owner = gameObject.GetComponent<TakeDamage> ();
		
		var targetDirection = ((Vector2)target.transform.position - (Vector2)transform.position).normalized;
		Debug.DrawRay (projectile.transform.position, targetDirection * 5, Color.white, 5f);
		projectile.rigidbody2D.AddForce (targetDirection * Random.Range (1000, 10000));
	}

}
