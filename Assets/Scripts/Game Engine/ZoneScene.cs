using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZoneScene : MonoBehaviour
{

	public static Droid player;
	public static Camera mainCamera ;
	public static Camera guiCamera;
	public static bool isMouseOnGui = false;
	public static Prefabs pf;
	public static GameObject pool;

	// Use this for initialization
	void Awake ()
	{
		pool = transform.Find ("Pools").gameObject;
		pf = GetComponent<Prefabs> ();
		guiCamera = GameObject.Find ("Gui").GetComponentInChildren<Camera> ();
		if (!guiCamera) {
			print ("NO GUI CAM!");
		}
		//	InvokeRepeating ("SlowUpdate", 3f, 1f);
	
	}

	void SlowUpdate ()
	{
				
	}

	void Update ()
	{
//				if (Input.GetKeyDown (KeyCode.Space)) {
//						print ("Projectile launcher is firing projectile! ");
//						GameObject projectile = this.GetPrefabInstance ("prjct_SlimeProjectile", transform.position);
//						var projectileControl = projectile.GetComponent<ProjectileBase> ();
//
//						projectileControl.owner = gameObject.GetComponent<TakeDamage> ();
//
//						var targetDirection = (Tools.GetMouseClickWorldPosition () - (Vector2)transform.position).normalized;
//						Debug.DrawRay (projectile.transform.position, targetDirection * 5, Color.white, 5f);
//						projectileControl.rigidbody2D.AddForce (targetDirection * 2000);
//				}
	}
}
 