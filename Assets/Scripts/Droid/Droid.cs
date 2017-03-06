using UnityEngine;
using System.Collections;

public class Droid : MonoBehaviour
{
		

	public DroidMachineGun Weapon;
	public LaserCutter LaserCutter ;
	public DroidInventory Inventory;
	public DroidWheeledMovement movement;
	public bool IsShooting = false;
	public bool IsHarvesting = false;
	public float LaserReach;
    public AudioClip DroidHit;
    AudioSource DroidAudioSource;
	public DroidMachineGun MachineGun;
	public DroidLazerGun LazerGun;

	public DroidGui gui;

	ParticleSystem electricalEffect;
	ParticleSystem fireEffect;

	TakeDamage health;

	void Awake ()
	{
        DroidAudioSource = gameObject.AddComponent<AudioSource>();
        
		health = GetComponent<TakeDamage> ();
		ZoneScene.player = this;
		movement = GetComponent<DroidWheeledMovement> ();
		Weapon = GetComponent<DroidMachineGun> ();
		LaserCutter = GetComponent<LaserCutter> ();
		MachineGun = GetComponent<DroidMachineGun> ();
		LazerGun = transform.Find ("Body").Find ("Head").GetComponentInChildren<DroidLazerGun> ();
		var effects = transform.Find ("Effects");

		electricalEffect = effects.transform.Find ("fx_ElectricalExplosion").particleSystem;
		fireEffect = effects.transform.Find ("FireExplosionEffect").particleSystem;
	}

	void Start ()
	{
		LaserReach = 10f;
		gui.SetHealth (health.Life, health.MaxLife);
	}


	void Update ()
	{
		if (Input.GetKey (KeyCode.Space)) {						
			//	Legs.brake = true;					
		} 
		
		if (Input.GetMouseButtonDown (0) && !ZoneScene.isMouseOnGui) {

		
			var target = Tools.GetMouseClickWorldPosition ();
			movement.SetAutoPilot (target);
			//	FxManager.PlaceFx (FxName.ElectricalExplosion, target);
							
		}

		if (Input.GetKey (KeyCode.E)) {
			MachineGun.PullTrigger ();

		}

		if (Input.GetKey (KeyCode.Q)) {
			LazerGun.PullTrigger ();			
		} 

	}

	void DamageTaken ()
	{			
		electricalEffect.Play ();
		fireEffect.Play ();
        DroidAudioSource.clip = DroidHit;
        DroidAudioSource.Play();
		gui.SetHealth (health.Life, health.MaxLife);

	}

	public void Die ()
	{
		Destroy (gameObject, 4f);
		fireEffect.Play ();
		electricalEffect.Play ();
	}
}
