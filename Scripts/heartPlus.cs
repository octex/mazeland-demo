using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartPlus : MonoBehaviour 
{
	public GameObject Mother;
	public SpriteRenderer hSpr;
	public Sprite hB;
	public Sprite hR;
	public ParticleSystem Effect;
	public GameObject us;

	void Start ()
	{
		Mother.GetComponent<Mother> ();		
	}

	void Update ()
	{
		var MainE = Effect.main;
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			hSpr.sprite = hB;
			MainE.startColor = Mother.GetComponent<Mother> ().color2; 
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			hSpr.sprite = hR;
			MainE.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}
	/*void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy (us);
		}
	}*/
}
