using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawPlatform : MonoBehaviour
{
	public GameObject Mother;
	public SpriteRenderer PltSpr;
	public Sprite PltR;
	public Sprite PltB;
	public float Ymin;
	public float Ymax;
	public int speed;
	public Rigidbody2D rb2d;
	public string direccion;
	private bool activated; 
	public Transform SawObj;

	void Start ()
	{
		Mother.GetComponent<Mother> ();
		rb2d.GetComponent<Rigidbody2D> ();
		activated = true;
	}

	void Update ()
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			PltSpr.sprite = PltB;
			activated = false;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			PltSpr.sprite = PltR;
			activated = true;
		}
		SawObj.position = transform.position;
		var tranY = transform.localPosition.y;
		rb2d.angularVelocity = 0;
		rb2d.angularDrag = 0;
		if (tranY >= Ymax)
		{
			direccion = "down";
		}
		else if (tranY <= Ymin)
		{
			direccion = "up";
		}
		if (direccion == "up" && activated == true)
		{
			rb2d.velocity = Vector2.up * speed;
		}
		else if (direccion == "down" && activated == true)
		{
			rb2d.velocity = Vector2.down * speed;
		}
		else if (activated == false)
		{
			rb2d.velocity = Vector2.zero;
		}
	}
}
