using UnityEngine;
using System.Collections;

/// <summary>
/// Baseclass inherited from MonoBase. Just so i can do my thing.  
/// </summary>
public class MonoBase : MonoBehaviour
{



	protected virtual void Awake ()
	{
		name = name.Replace ("(Clone)", "");
	}

	// Use this for initialization
	protected virtual void Start ()
	{
	
	}
	
	// Update is called once per frame
	protected virtual void Update ()
	{
	
	}
}
