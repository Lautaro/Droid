using UnityEngine;
using System.Collections;

public class LaserCutter : MonoBehaviour
{

          AudioSource laserAudioSource;
         public AudioClip laserSfx;
		ParticleSystem beam;
		bool beamIsOn = false;
        


		// Use this for initialization
		void Awake ()
		{
           

				beam = transform.SearchRecursively ("LaserCutter").GetComponent<ParticleSystem> ();
                laserAudioSource = gameObject.AddComponent<AudioSource>();
                laserAudioSource.clip = laserSfx;
				beam.Stop ();
            
		}

		public void BeamOff ()
		{
				print ("BEAM OFF ");
				beam.Stop ();
                laserAudioSource.Stop();
				beamIsOn = false;
		}

		public void BeamOn (float time)
		{
				StartCoroutine (laserTimer_cr (time));
		}

		IEnumerator laserTimer_cr (float time)
		{		
				float timer = 0;
				while (time > timer) {
						timer ++;
					
						yield return null;
				}
				BeamOff ();	
		}
/*
		IEnumerator HarvestDeposit_cr (MineralDeposit mineralDeposit)
		{
				var distance = Vector2.Distance (droid.transform.position, mineralDeposit.transform.position);
				if (distance < droid.laserReach) {
			
			
						var timer = 0f;
						droid.IsHarvesting = true;
						print ("Start harvesting");
						while (timer < harvestDuration) {
								laser.BeamOn ();
								timer += 0.1f;
								print (timer);
								yield return null;
						}
						print ("Stop harvesting");
						laser.BeamOff ();
						mineralDeposit.Harvest ();	
						droid.IsHarvesting = false;
				} else {
						print ("Out of reach: " + distance + " / " + droid.laserReach);
				}
		}*/
}
