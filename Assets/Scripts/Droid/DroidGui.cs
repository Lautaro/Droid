using UnityEngine;
using System.Collections;

public class DroidGui : MonoBehaviour
{
	UIProgressBar lazerGunCoolDown;
	UILabel lazerGunLabel;
	UILabel machineGunLabel;
	UILabel droidHealthLabel;
	UIProgressBar droidHealthBar;

	void Awake ()
	{
		lazerGunCoolDown = transform.Find ("LazerGunGui").GetComponentInChildren<UIProgressBar> ();
		lazerGunLabel = transform.Find ("LazerGunGui").GetComponentInChildren<UILabel> ();
		machineGunLabel = transform.Find ("MachineGunGui").GetComponentInChildren<UILabel> ();
			
		droidHealthLabel = transform.Find ("DroidHealth").GetComponentInChildren<UILabel> ();
		droidHealthBar = transform.Find ("DroidHealth").GetComponentInChildren<UIProgressBar> ();
		ZoneScene.player.gui = this;
	}


	public void SetMachinegunAmmo (int ammo)
	{
		machineGunLabel.text = "MachineGun: " + ammo;
	}

	public void SetLazergunAmmo (int ammo)
	{
		lazerGunLabel.text = "Lazer: " + ammo;
	}
		
	public void SetLazergunCoolDown (float cooldDownTime)
	{
		StartCoroutine (LazerGunCoolDown_cr (cooldDownTime));
	}

	public void SetHealth (int health, int maxHealth)
	{
		float percentage = (float)health / (float)maxHealth;
		droidHealthLabel.text = health.ToString ();
		droidHealthBar.value = percentage;

	}
	

	IEnumerator LazerGunCoolDown_cr (float cooldDownTime)
	{
		float endTime = Time.time + cooldDownTime; 

		while (endTime > Time.time) {
			float progressedTime = endTime - Time.time;
			float progressedPercentage = progressedTime / cooldDownTime;
			lazerGunCoolDown.value = progressedPercentage;
			yield return null;

		}
			
	}
}
