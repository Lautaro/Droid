using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{

		public AudioClip PickedUp;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
//				transform.Rotate (Vector3.right * Time.deltaTime * 70);
//				transform.Rotate (Vector3.up * Time.deltaTime * 70);

		}

		void OnTriggerEnter2D (Collider2D other)
		{
				if (other.name == "Player") {			
				
						audio.clip = PickedUp;
						audio.Play ();
						var effect = transform.Find ("Effect").GetComponent<ParticleSystem> ();
						var meshRenderer = GetComponent<MeshRenderer> ();
						//	effect.Emit (500);
						effect.Stop ();
						meshRenderer.enabled = false;
						Destroy (gameObject, 2f);
				}

		}

}
