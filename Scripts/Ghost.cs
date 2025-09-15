using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour 
{
	public GameObject Mother;
	public GameObject us;
	public GameObject DieEffect;
	public Rigidbody2D rb2d;
	public ParticleSystem EffectP;
	public SpriteRenderer GhostSpr;
	public Sprite GhostR;
	public Sprite GhostB;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		rb2d.GetComponent<Rigidbody2D> ();
		EffectP.GetComponent<ParticleSystem> ();
		GhostSpr.GetComponent<SpriteRenderer> ();
		DieEffect.GetComponent<ParticleSystem> ();
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			GhostSpr.sprite = GhostB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			GhostSpr.sprite = GhostR;
		}
		var mainD = DieEffect.GetComponent<ParticleSystem> ().main;
		var mainE = EffectP.main;
		rb2d.velocity = Vector2.left * 100;
		if (GhostSpr.sprite == GhostB) 
		{
			//mainE.startColor = Mother.GetComponent<Mother> ().color2;
			//mainD.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (GhostSpr.sprite == GhostR) 
		{
			//mainE.startColor = Mother.GetComponent<Mother> ().color1;
			//mainD.startColor = Mother.GetComponent<Mother> ().color1;
		}
		DieEffect.transform.position = us.transform.position;
	}

	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "platform" || other.gameObject.tag == "Player") 
		{
			Destroy (us);	
		}
	}
	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "platform" || other.gameObject.tag == "Player")
		{
			Destroy (us);
			//Instantiate (DieEffect);
		}
	}
}
