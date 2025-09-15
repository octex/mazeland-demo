using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour 
{
	public GameObject Mother;
	public GameObject Player;
	public bool active = false;
	public SpriteRenderer LeverSpr;
	public Sprite LeverOffR;
	public Sprite LeverOnR;
	public Sprite LeverOffB;
	public Sprite LeverOnB;
	public AudioSource LeverEffect;
	public ParticleSystem Effect;

	private bool touched;

	void Start () 
	{
		Player.GetComponent<Player> ();
		Mother.GetComponent<Mother> ();
		LeverSpr.GetComponent<SpriteRenderer> ();
		LeverEffect.GetComponent<AudioSource> ();
		Effect.GetComponent<ParticleSystem> ();
		touched = false;
	}
	
	void Update () 
	{
		var main = Effect.main;
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1 && active == false) 
		{
			LeverSpr.sprite = LeverOffB;
			main.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2 && active == false) 
		{
			LeverSpr.sprite = LeverOffR;
			main.startColor = Mother.GetComponent<Mother> ().color1;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1 && active == true) 
		{
			LeverSpr.sprite = LeverOnB;
			main.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2 && active == true) 
		{
			LeverSpr.sprite = LeverOnR;
			main.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}
	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player" && touched == false) 
		{
			touched = true;
			LeverEffect.Play ();
			if (active == false) 
			{
				active = true;
			}
			else if (active == true) 
			{
				active = false;
			}
		}
	}
	void OnCollisionExit2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			touched = false;
		}
	}
}
