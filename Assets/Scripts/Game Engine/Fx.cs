using UnityEngine;
using System.Collections;


/// <summary>
/// Visual and audio effect. After it finishes playing it goes back to its pool. Fxs are Prefabs and should only be invoked through the FX manager. 
/// </summary>
public class Fx : MonoBase
{
	public float LifeSpan;
	protected float startTime;
	public int angle = 180;
	bool inPool;

	public bool InPool {
		get {
			return inPool;
		}
	}

	/// <summary>
	/// FX with dynamic life span can have its life span timer reset so that it emits for a as long as it takes. 
	/// </summary>
	public bool dynamicLifeSpan;
	protected ParticleSystem effect;
	
	protected override void Awake ()
	{
		base.Awake ();
		name = name.Replace ("fx_", "");
		effect = GetComponent<ParticleSystem> ();
		effect.renderer.sortingLayerName = "ParticleLayer";
		if (!effect) {
			throw new UnityException ("Fx cannot find PraticleSystem. This is weird!");
		}
	}

	[ExecuteInEditMode]
	public  void Setup ()
	{
		gameObject.SetActive (true);
		inPool = false;
	
		var newRot = Quaternion.Euler (angle, 0, 0);
		transform.rotation = newRot;
		startTime = Time.time;


		//Dynamic lifa span checks the timer to take into consideration if the timer has been restarted. 
		//Non dynamic will die after set life span and cannot be prolonged. 
		if (dynamicLifeSpan) {
			InvokeRepeating ("SlowUpdate", 0, 0.25f);
		} else {
			Invoke ("Repool", LifeSpan);
		}


	}

	void Repool ()
	{
		gameObject.SetActive (false);
		CancelInvoke ();
		inPool = true;
		transform.parent = ZoneScene.pool.transform;
	}

	
	void SlowUpdate ()
	{
		var timeElapsed = Time.time - startTime;
		if (timeElapsed > LifeSpan) {
			
			effect.Stop (true);
			if (effect.particleCount < 1) {
				Invoke ("Repool", 0f);	
			}
		} else {
			effect.Play ();
		}
	}

	/// <summary>
	/// Resets the timer prolonging the Fx life span. Only works i FX.dynamicLifeSpan is true. OTherwise it throws an exception. 
	/// </summary>
	public void ResetTimer ()
	{
		if (dynamicLifeSpan) {
			startTime = Time.time;
		} else {
			throw new UnityException ("Dont call ResetTimer() on an fx that has not DynamicLifeSpan set to true. Its not natural!");
		}

		
	}
}
