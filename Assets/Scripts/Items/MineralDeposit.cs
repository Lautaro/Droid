using UnityEngine;
using System.Collections;

public class MineralDeposit : MonoBehaviour
{


		float harvestTimer = 10;



		public void Harvest ()
		{
				harvestTimer --;
				print ("Harvest: " + harvestTimer);
				if (harvestTimer < 1) {
						print ("MINERAL HARVESTED!");
						Destroy (gameObject);
				}
		}	

}
