using UnityEngine;
using System.Collections;

/// <summary>
/// This behaviour will use a WeaponBase and fire it at a target.
/// </summary>
 
[RequireComponent(typeof(WeaponsBase))]
public class FireAtTarget : AbilityBase
{
	public WeaponsBase weapon;
	public Transform target;

	/// <summary>
	/// The max duration for aiming between shots.
	/// </summary>
	public float MaxAimDuration; 

	void Awake ()
	{
		if (!weapon) {
			weapon = GetComponent<WeaponsBase> ();
			if (!weapon) {
				throw new UnityException ("FireAtTarget ability needs to have a WeaponsBase");
			}
			
		}
	}

	// Update is called once per frame
	void Update ()
	{
		if (weapon.state == WeaponState.idle) {
						
			StartCoroutine (AimAndShoot_cr ());						
						
		}	
	}

	IEnumerator AimAndShoot_cr ()
	{
		weapon.target = target = ZoneScene.player.transform;
		var aimDuration = Random.Range (0, MaxAimDuration);
		yield return new WaitForSeconds (aimDuration);

		weapon.PullTrigger ();
	}
}
