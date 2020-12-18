using UnityEngine;
using System.Collections;

public class DroidHand : MonoBehaviour
{

		InventorySlot slot;
		bool hasItem = false;

		// Use this for initialization
		void Awake ()
		{
	
				slot = transform.Find ("InventorySlot").GetComponent<InventorySlot> ();
				slot.info = "Droids hand";
				slot.gameObject.SetActive (false);
				
		}

			
		// Update is called once per frame
		void Update ()
		{
				if (hasItem) {
					
						var slotPos = ZoneScene.guiCamera.GetComponent<Camera>().ScreenToWorldPoint (Input.mousePosition);
					
						slotPos.x += 0.2f;
						slotPos.y += 0.2f;
			
						slot.transform.position = slotPos;	
				}
		}

		/// <summary>
		/// If item is not null the hands inventory slot is enabled and the item is bound to it. If null the slot is disabled.	/// </summary>
		/// <param name="item">Item.</param>
		public void Display (ItemBase item)
		{				
				if (item) {
						hasItem = true;
						slot.gameObject.SetActive (true);
						
				} else {
						hasItem = false;	
						slot.gameObject.SetActive (false);
				}
				slot.Display (item);
		}
}
