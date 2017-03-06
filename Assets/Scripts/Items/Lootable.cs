using UnityEngine;
using System.Collections;

[RequireComponent (typeof(ItemBase))]
//[RequireComponent (typeof(Collider2D))]
public class Lootable : MonoBehaviour
{
		ItemBase item;
		
		GameObject body;
		// Use this for initialization
		void Awake ()
		{				
				item = GetComponent<ItemBase> ();
				
				body = transform.Find ("Body").gameObject;

		}

		void OnMouseDown ()
		{
				
				
				AddToInventory ();				
		}

		protected void DebugPrint (string message)
		{
				var debugMe = GetComponent<DebugMe> ();
				if (debugMe) {
						debugMe.DebugThis (message);
				} else {
						print (message);
				}
		}

		void AddToInventory ()
		{
				var itemAccepted = ZoneScene.player.Inventory.AcceptItem (item);
				if (itemAccepted) {
				} else {
						DebugPrint ("Item was not accepted");
				}			
		}
}
