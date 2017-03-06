using UnityEngine;
using System.Collections;

public abstract class ItemBase : MonoBehaviour
{
		static int nexId = 1;
		int id;

		public int Id {
				get {
						return id;
				}
		}

		public int amount;
		public int maxAmount;
		public string itemName = "ItemBase";
		public string description = "ItemBase discription";
		public string info = "";
		public GameObject body;
		/// <summary>
		/// The slot containing this item .
		/// If item is not in a slot this will be null. 
		/// </summary>		
		
		public string guiImageName = "Energy";
		
		public	virtual void Awake ()
		{
				var x = transform.position.x;
				var y = transform.position.y;
				x += Random.Range (-20, 20);
				y += Random.Range (-20, 20);
				transform.Translate (new Vector2 (x, y));
				id = nexId ++;
				amount = Random.Range (1, 10);
				maxAmount = 10;
				body = transform.Find ("Body").gameObject;
		}

		public void InsertToInventory ()
		{
				body.SetActive (false);
		}
}
