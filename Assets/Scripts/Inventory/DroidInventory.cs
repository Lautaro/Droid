using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// Droids inventory. Here the actual items are stored. 
/// </summary>
public class DroidInventory : MonoBehaviour
{

		UIGrid grid ;
		DroidHand hand;
		ItemBase handItem;
		List<ItemBase> items = new List<ItemBase> ();
		int capacity;

		// Use this for initialization
		void Awake ()
		{
				hand = GameObject.Find ("Hand").GetComponent<DroidHand> ();
				grid = GetComponent<UIGrid> ();
				capacity = 4;
				items = Enumerable.Repeat<ItemBase> (null, capacity).ToList ();
		}

		void Start ()
		{
				
				ZoneScene.player.Inventory = this;	
				CreateSlots ();
		}


		/// <summary>
		/// Moves item to the hand if hand is empty. Returns false if hand is occupied. 
		/// </summary>
		/// <param name="inventoryIndex">Inventory index.</param>
		bool MoveFromInventoryToHand (int inventoryIndex)
		{
				if (handItem == null) {
			
						handItem = items [inventoryIndex];
						handItem.info = "This item is in droids hand";
						items [inventoryIndex] = null;
						return true;
				} else {
						return false;
				}
		}


		/// <summary>
		/// Releases the item from hand into argument-item .
		/// </summary>
		/// <param name="placeItemHere">Place item here.</param>
		void MoveFromHandToInventory (int inventoryIndex)
		{
				items [inventoryIndex] = handItem;
				items [inventoryIndex].info = "This item is in droids inventory slot " + inventoryIndex.ToString ();
				handItem = null;
		}

		public void InventorySlotClicked (InventorySlot slot)
		{
				
				//	DebugItemList ("A");	
				

				var slotNr = slot.GetSlotNr (); 
				var slotItem = items [slotNr];	//SLOT ITEM is the item that has been clicked. HELD ITEM is the item in the droids hand.		


				if (slotItem && !handItem) {
						//	print ("EMPTY HANDS PICKS UP ITEM");
						// EMPTY HANDS PICKS UP ITEM
						MoveFromInventoryToHand (slotNr);


						// FULL HAND PUTS ITEM IN EMPTY SLOT
				} else	if (!slotItem && handItem) {
						//	print ("FULL HAND PUTS ITEM IN EMPTY SLOT");
						MoveFromHandToInventory (slotNr);
						
			
						// BOTH HAND AND SLOT CONTAINS ITEMS
				} else 	if (handItem && slotItem) {
						//	print ("BOTH HAND AND SLOT CONTAINS ITEMS");
						//		DebugItemList ("B");
					
			
						var switchItems = false;
			
						if (handItem.itemName != slotItem.itemName) {
								// BOTH HAND AND SLOT HAS ITEMS. ITEMS ARE NOT OF THE SAME TYPES = SWICH ITEMS
								//			print ("BOTH HAND AND SLOT HAS ITEMS. ITEMS ARE NOT OF THE SAME TYPES = SWICH ITEMS");
								switchItems = true;
				
						} else {
								//	print ("MERGE ITEMS");
								// BOTH HAND AND OTHER SLOT HAS ITEMS. ITEMS ARE OF SAME TYPE = MERGE ITEMS;
				
								//If hand or other slot is full = SWITCH ITEMS
				
								if (handItem.amount == handItem.maxAmount || slotItem.amount == slotItem.maxAmount) {
										//		print ("MERGE - SWITCH ITEMS");
										switchItems = true;
								} else {
										//					print ("MERGE ITEMS - handitem / slotitem " + handItem.Id + " / " + slotItem.Id);
										var totalAmount = handItem.amount + slotItem.amount;
										var surplus = totalAmount - slotItem.maxAmount;
										
										handItem.amount = Mathf.Clamp (surplus, 0, handItem.maxAmount);
										slotItem.amount = totalAmount - handItem.amount;
										if (handItem.amount < 1) {
												handItem = null;
										}
								}
						}
			
						if (switchItems) {
								//SWITCH ITEMS
								//print ("SWITCH ITEMS - handitem / slotitem " + handItem.Id + " / " + slotItem.Id);
								var tempItem = slotItem;
								items [slotNr] = handItem;
								handItem = slotItem;								
						}		
				}	


				BindToGui ();
				//		DebugItemList ("B");	
		}


		/// <summary>
		/// Returns true if there is space in 
		/// </summary>
		/// <returns><c>true</c>, if item was accepted, <c>false</c> otherwise.</returns>
		/// <param name="newItem">New item.</param>
		public bool AcceptItem (ItemBase newItem)
		{
				for (int i = 0; i < items.Count; i++) {
						
						if (items [i] == null) {
								newItem.info = "Item is in droids inventoryslot " + i;
								items [i] = newItem;
								newItem = null;

								BindToGui ();
								return true;
						}
				}
				
				return false;
		}


		/// <summary>
		/// Checks if item exists in inventory and returns its slot nr. If inventory does not contain the item -1 is returned. If it exists more than once an exception is thrown.
		/// </summary>
		/// <returns>The items slot nr.</returns>
		/// <param name="checkItem">Check item.</param>
		int GetItemsSlotNr (ItemBase checkItem)
		{
				int nrOfOccurences = 0;
				foreach (var item in items) {
						if (item == checkItem) {
								nrOfOccurences ++;				
						}
				}

				if (nrOfOccurences < 1) {
						return -1;
				}

				if (nrOfOccurences > 1) {
						throw new UnityException ("The same Item exists in the same inventory more than once! This conflicts with the laws of reality. Bad developer, BAD!");
				}
				return items.IndexOf (checkItem);
		}

		public InventorySlot[] GetAllSlots ()
		{
				return GetComponentsInChildren<InventorySlot> ();
		}


		/// <summary>
		///  Empties each IngentorySlut gui then 
		/// goes through the items in inventory and displays them in the GUI.
		/// </summary>
		public void BindToGui ()
		{	
				var slots = GetAllSlots ();

				if (items.Capacity != slots.Length) {
						throw new UnityException ("Inventory Item List count and amount of slot GUIs must is not the same!");
				}

				foreach (var slot in slots) {
						slot.EmptySlot ();
				}
			

				//Put each item in its slot
				for (int i = 0; i < items.Capacity; i++) {

						if (items [i] != null) {
									
								var slot = slots [i];
								items [i].InsertToInventory ();
								slot.Display (items [i]);
						}
				}
				
				grid.Reposition ();	
				hand.Display (handItem);		
		}

		/// <summary>
		/// Prints each item in the player inventory to the log.
		/// </summary>
		/// <param name="id">Identifier.</param>
		void DebugItemList (string id)
		{
				print ("====== " + id + " ======");
				for (int i = 0; i < items.Count; i++) {
						
						var item = items [i];
						if (item) {
								string output = "INVENTORY " + i;
								output += (": " + item.info + " " + item.itemName + " " + item.amount);
								print (output);
						} 
						
				}
				if (handItem) {
						print ("Hand: " + handItem.info + handItem.itemName + " " + handItem.amount);
				} else {
						//print ("Hand: null");
				}
				print ("----------------");
		}

		/// <summary>
		/// Creates the GUI slots. 
		/// </summary>
		void CreateSlots ()
		{
				if (items.Capacity != GetAllSlots ().Length) {				

						for (int i = 0; i < capacity; i++) {						
								var go = NGUITools.AddChild (gameObject, this.GetPrefabInstance ("gui_InventorySlot")); 
								var slot = go.GetComponent<InventorySlot> ();
								slot.SetSlotNr (i);
								slot.info = "Inventory slot #" + i;
						}
				}
				BindToGui ();
				grid.Reposition ();				
		}
}
