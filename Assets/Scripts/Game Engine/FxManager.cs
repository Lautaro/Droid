using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Manages pooling, instantiating, setup, and placement of visual effects. 
/// </summary>
public class FxManager : MonoBehaviour
{
	static List<Fx> fxPool; 

/// <summary>
/// Check if parent has the effect. If it has a dynamic effect, reset its timer. If there is no effect get one from pool or instantiate a new one.
/// </summary>
/// <returns>The fx.</returns>
/// <param name="name">Name.</param>
/// <param name="parent">Parent.</param>
	public static Fx PlaceFx (FxName fxName, Transform parent)
	{

		Fx newFx = null;
		
		//Check if the parent already has this type of effect. 
		var fxs = parent.GetComponentsInChildren<Fx> ();
		
		
		foreach (var fx in fxs) {
			
			if (fx.name == FxName.Burn.ToString ()) {
				newFx = fx;
			}
		}

		if (newFx) {

			//If there is already a burn effect, prolong its life span. 
			newFx.ResetTimer ();

		} else {
			//Get a fx from pool
			newFx = GetFromPool (fxName);
		}


		newFx.transform.parent = parent;
        var pos = parent.position;
		newFx.transform.position = new Vector3(pos.x, pos.y, -3);
		return newFx;
	
	}


	/// <summary>
	/// GFxTypex from pool or instantiate if there is none ready for use. 
	/// </summary>

	static Fx GetFromPool (FxName fxName)
	{
		Fx fxToBeReturned = null;
		
		//Initiate pool if nescessary
		if (fxPool == null) {
			fxPool = new List<Fx> ();
		}
		
		//Check if there is a ready instance in the pool, if not instantiate one. 
		foreach (var go in fxPool) {
			
			var checkIfReady = go.GetComponent<Fx> ();
			
			//CHECK IF FX IS CORRECT TYPE AND IS READY TO BE USED
			if (checkIfReady.name == fxName.ToString () 
				&& checkIfReady.InPool) {
				
				fxToBeReturned = checkIfReady;
				break;
			}
		}
		
		//If there is no fx found, instantiate a new one
		if (fxToBeReturned == null) {
			var prefabname = "fx_" + fxName;
			GameObject go = ZoneScene.pf.GetPrefabInstance (prefabname);
			fxToBeReturned = go.GetComponent<Fx> ();
			fxPool.Add (fxToBeReturned);
			
		} 
		
		if (!fxToBeReturned) {
			throw  new UnityException ("Fx not found in pool and not instantiated from prefab. Wai?! This should not be. ");
		}
		
		fxToBeReturned.Setup ();
		return fxToBeReturned;
	}
}


/// <summary>
/// All the availablFxTypects. Every enum item must be the actual prefab name minus the fx_ prefix. 
/// </summary>
public enum FxName
{
	Burn, 
	ElectricalExplosion, 
	FireExplosion, 
	SlimeExplosion, 
	MachineGunHit, 
}
