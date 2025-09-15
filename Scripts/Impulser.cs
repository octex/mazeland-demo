using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulser : MonoBehaviour 
{
	public ParticleSystem Effect;
	public GameObject Mother;
	public GameObject Player;
	public float ImpulseForce;
	private Vector2 ImpulseVector;
	public SpriteRenderer ImpulserSpr;
	public Sprite ImpulserB;
	public Sprite ImpulserR;
	public string direccion;
	public AudioSource EffectSoundImpulser;

	void Start () 
	{
		Effect.GetComponent<ParticleSystem> ();
		Mother.GetComponent<Mother> ();
		Player.GetComponent<Player> ();
		EffectSoundImpulser.GetComponent<AudioSource> ();
	}

	void Update ()
	{
		var Main = Effect.main;
		if (direccion == "up") 
		{
			ImpulseVector = Vector2.up;
		}
		else if (direccion == "down") 
		{
			ImpulseVector = Vector2.down;
		}
		else if (direccion == "right")
		{
			//Player.GetComponent<Player> ()._x = ImpulseVector.x;
			ImpulseVector = new Vector2(ImpulseForce,0);
		}
		else if (direccion == "left")
		{
			//ImpulseVector.x = ImpulseForce;
			//ImpulseVector.y = Player.GetComponent<Player> ().rb2d.velocity.y;
			ImpulseVector = new Vector2(ImpulseForce,Player.GetComponent<Player>().rb2d.velocity.y);
			//ImpulseVector = new Vector2(Player.GetComponent<Player>().rb2d.velocity.x * Player.GetComponent<Player>().speed, 0);
			//ImpulseVector = Vector2.left;
		}
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			ImpulserSpr.sprite = ImpulserB;
			//Main.startColor = Mother.GetComponent<Mother>().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			ImpulserSpr.sprite = ImpulserR;
			//Main.startColor = Mother.GetComponent<Mother>().color1;
		}
		//Player.GetComponent<Player>().rb2d.AddForce(new Vector2(-ImpulseForce,0));
		//Player.GetComponent<Player> ().rb2d.AddForce(ImpulseVector);
	}

	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			if (direccion == "right" || direccion == "left")
			{
				Player.GetComponent<Player> ().rb2d.AddForce(ImpulseVector, ForceMode2D.Impulse );
			}
			else
			{
				Player.GetComponent<Player> ().rb2d.velocity = ImpulseVector * ImpulseForce;
			}
			EffectSoundImpulser.Play ();
		}
	}
}