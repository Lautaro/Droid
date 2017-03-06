using UnityEngine;
using System.Collections;


/// <summary>
/// The GUI representation of an item (ItemBase).  Does not contain the item but will bind to it and display its info.  
/// </summary>
public class InventorySlot : MonoBehaviour
{			
		UILabel amount;
		UILabel itemName;
		UILabel nr;
		UISprite image;
		public	string info; //Free text used for debugging. Where is this slot?

		void Awake ()
		{
				amount = transform.Find ("Amount").GetComponent<UILabel> ();
				itemName = transform.Find ("ItemName").GetComponent<UILabel> ();
				nr = transform.Find ("Nr").GetComponent<UILabel> ();
				image = transform.Find ("ItemImage").GetComponent<UISprite> ();
		}





		/// <summary>
		/// Binds labels and image to the ItemBase object. 
		/// </summary>
		public	void Display (ItemBase item)
		{
				if (item != null) {

						itemName.enabled = true;
						amount.enabled = true;
						nr.enabled = true;
						image.enabled = true;

						image.spriteName = item.guiImageName;
						itemName.text = item.Id.ToString ();//item.name;
						amount.text = item.amount.ToString ();
				} 
		}

		public string GetItemName ()
		{
				return itemName.text;
		}

		public void EmptySlot ()
		{
				itemName.enabled = false;
				itemName.text = "empty";
				amount.enabled = false;
				amount.text = "0";
				nr.enabled = true;
				image.enabled = false;
				image.spriteName = "";
		}
	
		/// <summary>
		/// Set what position this slot has in its container	
		/// </summary>		
		public void SetSlotNr (int index)
		{
				nr.text = index.ToString ();
		}

		public int GetSlotNr ()
		{
				return  int.Parse (nr.text);
		}

		void OnHover (bool isOver)
		{
				if (isOver) {
						ZoneScene.isMouseOnGui = true;
	
				} else {
						ZoneScene.isMouseOnGui = false;
				}
		}

		void OnPress (bool isDown)
		{
				
				if (isDown) {
						SendMessageUpwards ("InventorySlotClicked", this);
				}
		}


}
