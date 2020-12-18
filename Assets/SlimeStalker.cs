using UnityEngine;
using System.Collections;

public class SlimeStalker : CreatureBase
{
    public AudioClip SlimeHitSfx;
    AudioSource SlimeAudioSource;


	// Use this for initialization
	void Start ()
	{
        SlimeAudioSource = gameObject.AddComponent<AudioSource>();
		SlimeAudioSource.volume = 0.1f;

		SlimeAudioSource.clip = SlimeHitSfx;
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
		GetComponent<Rigidbody2D>().isKinematic = true;
		GetComponent<Collider2D>().enabled = false;
		Destroy (gameObject, 3f);
		SlimeAudioSource.clip = SlimeHitSfx;
		SlimeAudioSource.volume = 0.5f;

		SlimeAudioSource.Play();
	}
}
