using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour 
{
	public GameObject Mother;
	public ParticleSystem EffectP;
	public Transform Player;
	public Transform Target;
	public SpriteRenderer TeleportSpr;
	public Sprite TeleportB;
	public Sprite TeleportR;
	public AudioSource TeleportEffect;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		EffectP.GetComponent<ParticleSystem> ();
		TeleportEffect.GetComponent<AudioSource> ();
	}

	void Update ()
	{
		var mainEffect = EffectP.main;
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			//EffectP.GetComponent<ParticleSystem> ().main.startColor = Color.black;
			mainEffect.startColor = Color.black;
			TeleportSpr.sprite = TeleportB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			//EffectP.GetComponent<ParticleSystem> ().main.startColor = Color.red;
			mainEffect.startColor = Color.red;
			TeleportSpr.sprite = TeleportR;
		}
	}
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			TeleportEffect.Play ();
			Player.position = Target.position;
		}
	}
}
