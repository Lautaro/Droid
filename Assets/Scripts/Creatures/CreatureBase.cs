using UnityEngine;
using System.Collections;


public class CreatureBase : MonoBehaviour
{
	public CreatureState State = CreatureState.Idle ;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void Die ()
	{
		Invoke ("SendToPool", 2f);


	}

	void SendToPool ()
	{
		gameObject.SetActive (false);
	}
}

public enum CreatureState
{
	Idle, 
	Busy, 
	Dead
}
