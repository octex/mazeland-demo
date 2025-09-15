using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metrallet : MonoBehaviour 
{
	public GameObject Mother;
	public SpriteRenderer MetraSpr;
	public Sprite MetraR;
	public Sprite MetraB;
	public GameObject bullet;
	public GameObject Lever;
	public GameObject Clock;
	public Transform FirePos;
	public AudioSource FireSnd;
	public AudioSource FireAlarm;
	public int newMin;
	public int newSec;

	private int times;

	void Start () 
	{
		//AlarmFire (0.75f);
		Mother.GetComponent<Mother> ();
		MetraSpr.GetComponent<SpriteRenderer> ();
		Lever.GetComponent<LeverMetra> ();
		Clock.GetComponent<Boss01Timer> ();
		times = 0;
		//InvokeRepeating ("FireBullet", 1.0f, 2.0f);
	}

	void Update () 
	{
		if (Lever.GetComponent<LeverMetra> ().Active == true)
		{
			AlarmFire (0.75f);
		}
		if (Clock.GetComponent<Boss01Timer> ().min == 0 && Clock.GetComponent<Boss01Timer> ().sec == 0)
		{
			Lever.GetComponent<LeverMetra> ().EffectPs.gameObject.SetActive (true);
		} 
		else
		{
			Lever.GetComponent<LeverMetra> ().EffectPs.gameObject.SetActive (false);
		}
		var mainBP = bullet.GetComponent<Bullet> ().EffectP.main;
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			MetraSpr.sprite = MetraB;
			bullet.GetComponent<Bullet> ().BulletSpr.sprite = bullet.GetComponent<Bullet> ().BB;
			mainBP.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			MetraSpr.sprite = MetraR;
			bullet.GetComponent<Bullet> ().BulletSpr.sprite = bullet.GetComponent<Bullet> ().BR;
			mainBP.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}

	void AlarmFire(float time)
	{
		FireAlarm.Play ();
		Invoke ("AlarmStop", time);
		Lever.GetComponent<LeverMetra> ().Active = false;
		Clock.GetComponent<Boss01Timer> ().min = newMin;
		Clock.GetComponent<Boss01Timer> ().sec = newSec;
	}
	void AlarmStop()
	{
		FireAlarm.Stop ();
		InvokeRepeating ("FireBullet", 0.1f, 1.0f);
	}
	void FireBullet()
	{
		times++;
		Instantiate (bullet);
		FireSnd.Play();
		bullet.transform.position = FirePos.position + new Vector3(Random.Range(1,2),Random.Range(1,2));
		if (times == 5) 
		{
			CancelInvoke ("FireBullet");
			times = 0;
		}
	}
}
