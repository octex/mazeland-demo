using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour 
{
	public GameObject Mother;
	public SpriteRenderer BombSpr;
	public Sprite BombR;
	public Sprite BombB;
	public GameObject us;
	public Rigidbody2D rb2d;
	public Animator ExpAnim;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		BombSpr.GetComponent<SpriteRenderer> ();
		rb2d.GetComponent<Rigidbody2D> ();
		ExpAnim.enabled = false;
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			BombSpr.sprite = BombB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			BombSpr.sprite = BombR;
		}
	}
	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "platform" || other.gameObject.tag == "Player" || other.gameObject.tag == "trap" || other.gameObject.tag == "plt") 
		{
			if (BombSpr.sprite == BombB)
			{
				ExpState ("ExplosionBlack");
			}
			else if (BombSpr.sprite == BombR) 
			{
				ExpState ("ExplosionRed");
			}
			ExpAnim.enabled = true;
			transform.gameObject.tag = "trap";
			rb2d.bodyType = RigidbodyType2D.Static;
		}
	}
	public void ExpState (string state)
	{
		if (state != null) 
		{
			ExpAnim.Play (state);
		}
	}
	void Kill()
	{
		Destroy(us);
	}
}
