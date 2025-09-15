using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverMetra : MonoBehaviour 
{
	public Rigidbody2D pltF, plt2cond;
	public GameObject Mother;
	public GameObject Clock;
	public SpriteRenderer LeverMSpr;
	public Sprite LeverMRoff;
	public Sprite LeverMRon;
	public Sprite LeverMBoff;
	public Sprite LeverMBon;
	public bool Active;
	public ParticleSystem EffectPs;
	public Transform Player;
	public Transform Spawn;

	private bool touched;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		LeverMSpr.GetComponent<SpriteRenderer> ();
		Clock.GetComponent<Boss01Timer> ();
		//EffectPs.GetComponent<ParticleSystem> ();
		touched = false;
	}

	void Update () 
	{
		if (Clock.GetComponent<Boss01Timer> ().sec == 0 && Clock.GetComponent<Boss01Timer> ().min == 0)
		{
			if (pltF.transform.localPosition.x > 170)
			{
				pltF.velocity = Vector2.left * 150;
			}
			else
			{
				pltF.velocity = Vector2.zero;
			}

			if (plt2cond.transform.localPosition.x > 110)
			{
				plt2cond.velocity = Vector2.left * 150;
			}
			else
			{
				plt2cond.velocity = Vector2.zero;
			}
		}
		else
		{
			if (pltF.transform.localPosition.x < 200)
			{
				pltF.velocity = Vector2.right * 150;
			}
			else
			{
				pltF.velocity = Vector2.zero;
			}

			if (plt2cond.transform.localPosition.x < 200)
			{
				plt2cond.velocity = Vector2.right * 150;
			}
			else
			{
				plt2cond.velocity = Vector2.zero;
			}
		}
		//var MainPs = EffectPs.main;
		if (Active == false && Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			LeverMSpr.sprite = LeverMBoff;
			//MainPs.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (Active == true && Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			//MainPs.startColor = Mother.GetComponent<Mother> ().color2;
			LeverMSpr.sprite = LeverMBon;
		}
		else if (Active == false && Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			LeverMSpr.sprite = LeverMRoff;
			//MainPs.startColor = Mother.GetComponent<Mother> ().color1;
		}
		else if (Active == true && Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			LeverMSpr.sprite = LeverMRon;
			// MainPs.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player" && touched == false && Clock.GetComponent<Boss01Timer>().sec == 0 && Clock.GetComponent<Boss01Timer>().min == 0)
		{
			Active = true;
			touched = true;
			Player.position = Player.GetComponent<Player> ().Spawn.position;
		}
	}

	void OnCollisionExit2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			touched = false;
		}
	}
}
