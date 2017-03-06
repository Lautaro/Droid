using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Prefabs : MonoBehaviour
{
	public static Dictionary<string, GameObject> PF = new Dictionary<string, GameObject> ();

	// Use this for initialization
	void Awake ()
	{
		LoadAssetsAtPath ("Prefabs/Effects/");
		LoadAssetsAtPath ("Prefabs/InventoryGui/");
		LoadAssetsAtPath ("Prefabs/Creatures/");	
	}

	void Start ()
	{
		//Check all prefabs
		for (int i = 0; i < PF.Count; i++) {
			GameObject go = PF.ElementAt (i).Value;
			//	Instantiate (go, new Vector2 (0, 0), Quaternion.identity);
			if (go == null) {

				print ("Prefab did not load: " + PF.ElementAt (i).Key.ToString ());
			}
		}
	}



	void LoadAssetsAtPath (string path)
	{
		var prefabs = Resources.LoadAll (path, typeof(GameObject));
		
		foreach (GameObject go in prefabs) {
			PF.Add (go.name, go);
		}
	}	




}
