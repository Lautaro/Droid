using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				//rigidbody2D.AddForce (Vector3.up * 100);
		}

		void OnHover (bool isOver)
		{
				if (isOver) {
						print ("i am hovered");
				} else {
						print ("NOT");
				}
		}

}
