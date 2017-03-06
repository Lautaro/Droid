using UnityEngine;
using System.Collections;

public class SlimeStalker : CreatureBase
{
    public AudioClip DeathSfx;
    AudioSource SlimeAudioSource;


	// Use this for initialization
	void Start ()
	{
        SlimeAudioSource = gameObject.AddComponent<AudioSource>();
        SlimeAudioSource.clip = DeathSfx;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void Die ()
	{
		FxManager.PlaceFx (FxName.SlimeExplosion, transform);
	
		GetComponentInChildren<Renderer> ().enabled = false;
		State = CreatureState.Dead;
		rigidbody2D.isKinematic = true;
		collider2D.enabled = false;
		Destroy (gameObject, 3f);
        SlimeAudioSource.Play();
	}
}
