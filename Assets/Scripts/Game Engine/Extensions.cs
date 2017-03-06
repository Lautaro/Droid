using UnityEngine;
using System.Collections;



public static class Extensions
{
	public static Transform SearchRecursively (this Transform target, string name)
	{
		if (target.name == name)
			return target;
			
		for (int i = 0; i < target.childCount; ++i) {
			var result = SearchRecursively (target.GetChild (i), name);
				
			if (result != null)
				return result;
		}
			
		return null;
	}


	/// <summary>
	/// Creates a new instance froma a prefab by name from all prefabs loaded into AllPF dictionary from the Prefabs manager.
	/// </summary>
	/// <returns>The prefab.</returns>
	/// <param name="target">Target.</param>
	/// <param name="name">Name.</param>
	public static GameObject GetPrefabInstance (this MonoBehaviour target, string name)
	{
			
		var go = Prefabs.PF [name] as GameObject;
	
		return GameObject.Instantiate (go, new Vector2 (0, 0), Quaternion.identity) as GameObject;
	}

	public static GameObject GetPrefabInstance (this MonoBehaviour target, string name, Vector2 position)
	{		
		var go = Prefabs.PF [name] as GameObject;
		return GameObject.Instantiate (go, position, Quaternion.identity) as GameObject;
	}


}
	


