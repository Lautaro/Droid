using UnityEngine;
using System.Collections;

public class MineralBlue : ItemBase
{
		public	override 	void Awake ()
		{
				base.Awake ();
				itemName = "Blue Mineral";
				guiImageName = "Crystal";
				description = "This is a blue mineral. You could use it for doing blue mineral stuff.";
		}

}
