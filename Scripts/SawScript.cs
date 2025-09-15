using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScript : MonoBehaviour
{
	public GameObject Mother;
	public SpriteRenderer SawSpr;
	public Sprite SawR;
	public Sprite SawB;
	public Rigidbody2D rb2d;

	void Start ()
	{
		Mother.GetComponent<Mother> ();
		rb2d.GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			this.gameObject.GetComponent<PolygonCollider2D> ().enabled = false;
			SawSpr.sprite = SawB;
			gameObject.tag = "trap";
			rb2d.angularVelocity = 0;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			this.gameObject.GetComponent<PolygonCollider2D> ().enabled = true;
			rb2d.angularVelocity = 1000;
			//transform.rotation = Quaternion.Euler (new Vector3(0,0,100));
			SawSpr.sprite = SawR;
			gameObject.tag = "trap";
		}
	}
}