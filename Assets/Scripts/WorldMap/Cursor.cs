using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour
{
		bool coordinateSelected = false;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public void SetPosition (Vector2 position)
		{
				if (!coordinateSelected) {
						transform.position = position;
				}
		}


		public void Blip (Vector2 position)
		{
				StartCoroutine (Blip_cr (position));
		}

		IEnumerator Blip_cr (Vector2 position)
		{
				coordinateSelected = true;
				SetPosition (position);

				
				var duration = 0.1f;
				var startColor = renderer.material.color;
				var targetColor = new Color (0f, 215f, 255f, 255f);
				
				var startTime = Time.time;
				var progress = 0f;

				while (progress < 1) {
				
						renderer.material.color = Color.Lerp (startColor, targetColor, progress);
						progress = (Time.time - startTime) / duration;
						
						yield return  null;
				}
				print ("done lerping up");
				progress = 0;
				startTime = Time.time;
				while (progress < 1) {
				
						renderer.material.color = Color.Lerp (targetColor, startColor, progress);
						progress = (Time.time - startTime) / duration;						
						yield return  null;
				}

				renderer.material.color = startColor;
				print ("done lerping down");
				coordinateSelected = false;
		}

}
