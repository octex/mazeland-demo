using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour 
{
	public GameObject us;
	public Rigidbody2D rb2d;
	public ParticleSystem EffectP;
	public SpriteRenderer BulletSpr;
	public Sprite BR;
	public Sprite BB;

	void Start () 
	{
		rb2d.GetComponent<Rigidbody2D> ();
		EffectP.GetComponent<ParticleSystem> ();
		BulletSpr.GetComponent<SpriteRenderer> ();
	}

	void Update () 
	{
		rb2d.velocity = Vector2.right * 250;
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		Destroy (us);	
	}
}
