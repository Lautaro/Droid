using UnityEngine;
using System.Collections;

public class MineralRed : ItemBase
{

		public	override void Awake ()
		{
				base.Awake ();
				itemName = "Red Mineral";
				guiImageName = "Mineral";
				description = "A beautiful red mineral. Like a diamond. But red. And not crystal. So not a diamond.";
		}
}
