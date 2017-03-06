using UnityEngine;
using System.Collections;

public class Bloop : CreatureBase
{

	AbilityBase idleState;
	AbilityBase hostileState;

	// Use this for initialization
	void Awake ()
	{
		idleState = GetComponent<MoveRandomly> ();
		hostileState = GetComponent<FireAtTarget> ();	
		SwitchToIdleState ();
	}

	public void Die ()
	{
		StartCoroutine (Die_cr ());
	}

	IEnumerator Die_cr ()
	{
		var deathEffect = transform.Find ("DeathEffect").particleSystem;//GetComponent<ParticleSystem> ();
		deathEffect.Play (true);
		
		var brain = transform.Find ("Body").transform.Find ("Brain").gameObject;
		
			
		
		var bloop = GetComponent<Bloop> ();
		var abilities = GetComponents<AbilityBase> ();

		foreach (var ability in abilities) {
						
			ability.enabled = false;				
		}
		var material = brain.renderer.material;
		var color = material.color;

		var duration = 3f;
		var startTime = Time.time;
		var progress = 0f;
		
		while (progress < 1) {
			
			color.a = Mathf.Lerp (1, 0, progress);
			material.color = color;
			progress = (Time.time - startTime) / duration;
			yield return  null;
		} 

		yield return new WaitForSeconds (2);

		brain.SetActive (false);
		var animator = GetComponent<Animator> ();
		animator.enabled = false;
		bloop.enabled = false;

	}

	public void DamageTaken ()
	{
		if (idleState.enabled == true) {
			SwitchToHostileState ();
		}
	}

	void SwitchToHostileState ()
	{
		var abilities = GetComponents<AbilityBase> ();
		foreach (var ability in abilities) {

			if (ability.GetType () == typeof(FireAtTarget)) {
				ability.enabled = true;
			} else {
				ability.enabled = false;
			}
		}
	}

	void SwitchToIdleState ()
	{
		var abilities = GetComponents<AbilityBase> ();
		foreach (var ability in abilities) {
			
			if (ability.GetType () == typeof(FireAtTarget)) {
				ability.enabled = false;
			} else {
				ability.enabled = true;
			}
		}
	}

}
