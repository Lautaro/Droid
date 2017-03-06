using UnityEngine;
using System.Collections;

public class DroidLazerGun : WeaponsBase
{

	LineRenderer line;
	float beamLength;
     AudioSource laserAudioSource;
    public AudioClip laserSfx;

	/// <summary>
	/// Amount of shots fired with BurstFire
	/// </summary>
	public int  ShotsPerBurst;//
	
	/// <summary>
	/// The duration of the burst.
	/// </summary>
	public float BurstDuration;

	// Use this for initialization
	void Start ()
	{
		//line.renderer.sortingLayerName = "ParticleLayer";
		beamLength = 50f;
        laserAudioSource = gameObject.AddComponent<AudioSource>();
        laserAudioSource.clip = laserSfx;
        laserAudioSource.volume = 1f;
		line = GetComponentInChildren<LineRenderer> ();
		line.SetPosition (1, new Vector3 (0.2f, 0, 0f));
		ZoneScene.player.gui.SetLazergunAmmo (Ammunition);
	
	}

	protected override void OnWeaponFired ()
	{
		StartCoroutine (FireWeapon_cr ());			
	}

	IEnumerator FireWeapon_cr ()
	{

		var shotDuration = BurstDuration / ShotsPerBurst;

		var damagePerShot = Damage / Damage;
		line.SetPosition (1, new Vector3 (0.2f, beamLength, 0f));
        laserAudioSource.Play();
        laserAudioSource.volume = 0.6f;
        laserAudioSource.loop = true;

		for (int i = 0; i < ShotsPerBurst; i++) {
					
			var rayDirection = line.transform.TransformDirection (Vector2.up);
			var hits = Physics2D.RaycastAll (line.transform.position, rayDirection, 50f * 1.7f);
		
			foreach (RaycastHit2D hit in hits) {
				var target = hit.collider;
				if (target.tag == "Creature") {
					var creature = target.GetComponent<TakeDamage> ();
					if (creature) {
						creature.LazerHit (damagePerShot);
					}
				}								
			}
			yield return new WaitForSeconds (shotDuration);
		}

		line.SetPosition (1, new Vector3 (0.2f, 0, 0f));
        laserAudioSource.Stop();

	}

	protected override void SpendAmmunition (int i)
	{
		base.SpendAmmunition (i);
		ZoneScene.player.gui.SetLazergunAmmo (Ammunition);
		ZoneScene.player.gui.SetLazergunCoolDown (CoolDownTime);
	}


}
