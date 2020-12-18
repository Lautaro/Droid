using UnityEngine;
using System.Collections;

public class WeaponsBase : MonoBehaviour
{
	public WeaponState state;	

	public float CoolDownTime;
	public float ReloadTime;	
	public float Damage;
	public int Ammunition; 
	public int MaxAmmunition;
	public Transform target;
	public AudioClip ClickSfx;


	void Awake ()
	{
		state = WeaponState.idle;
	}

	/// <summary>
	/// Checks if weapon can fire. Sets stat to firing for CoolDownTime. Uses ammunition and calls OnBulletFired. OR clicks. 
	/// </summary>
	/// <returns>The trigger_cr.</returns>
	public void PullTrigger ()
	{
		StartCoroutine (PullTrigger_cr ());

	}


	IEnumerator PullTrigger_cr ()
	{
		//	//print ("Trigger Pulled");
		if (state == WeaponState.idle) {				
			if (Ammunition < 1) {
				if (ClickSfx && GetComponent<AudioSource>()) {
					GetComponent<AudioSource>().clip = ClickSfx;
					GetComponent<AudioSource>().Play ();
					state = WeaponState.noAmmo;
				}
			} else {
				state = WeaponState.firing;
				SpendAmmunition (1);
				//				//print ("Calling on BulletFired");
			

				OnWeaponFired ();
				yield return new WaitForSeconds (CoolDownTime);
				state = WeaponState.idle;
			}
		} else {
			//		//print ("did not fire cause state = " + state);
		}
	}

	protected virtual void SpendAmmunition (int i)
	{
		Ammunition --;
	}

	/// <summary>
	/// Called when PullTrigger has evaluated that weapon can be fired and spent ammunition. 
	/// </summary>
	protected virtual void OnWeaponFired ()
	{
		
	}

	protected	IEnumerator Reload_cr ()
	{
		state = WeaponState.reloading;
		yield return new WaitForSeconds (ReloadTime);
		state = WeaponState.idle;
	}
}

public enum WeaponState
{
	idle, 
	firing, 
	coolDown,
	noAmmo, 
	reloading
}
