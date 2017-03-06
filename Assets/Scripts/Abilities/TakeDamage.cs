using UnityEngine;
using System.Collections;


/// <summary>
/// Ability for creatures that can be shot, hit and damaged. 
/// </summary>
public class TakeDamage : AbilityBase
{

    public AudioClip GettingHit;

    AudioSource takeDamageAudioSource;
	public	int  MaxLife;
	public	int  life;

	public int Life {
		get {
			return life;
		}
		set {
			life = value;
			if (life < 1) {
				SendMessage ("Die");
			}
		}
	}

    void Awake()
    {
        takeDamageAudioSource = gameObject.AddComponent<AudioSource>();
    }


	public void LazerHit (float damage)
	{
		FxManager.PlaceFx (FxName.Burn, transform);

		Life -= (int)damage;

		SendMessage ("DamageTaken", SendMessageOptions.DontRequireReceiver);
        takeDamageAudioSource.PlayOneShot(GettingHit);
	}

	public void MachineGunHit (Vector2 hitOrigin)
	{
		FxManager.PlaceFx (FxName.MachineGunHit, transform);
		Life -= 5;
		Vector2 direction = ((Vector2)transform.position - hitOrigin).normalized;
		rigidbody2D.AddForce (direction * 400);
		SendMessage ("DamageTaken", SendMessageOptions.DontRequireReceiver);
        takeDamageAudioSource.PlayOneShot(GettingHit);

	}

	public void ProjectileHit (Vector2 hitOrigin, float damage, float forceMultiplier)
	{
		Life -= (int)damage;
		Vector2 direction = ((Vector2)transform.position - hitOrigin).normalized;
		rigidbody2D.AddForce (direction * forceMultiplier);
		SendMessage ("DamageTaken", SendMessageOptions.DontRequireReceiver);
        takeDamageAudioSource.PlayOneShot(GettingHit);
	}
}
