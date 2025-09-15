using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSource : MonoBehaviour 
{
	public Light Source;
	public ParticleSystem EffectL;
	public GameObject Mother;
	public SpriteRenderer LightSpr;
	public Sprite LightR;
	public Sprite LightB;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			LightSpr.sprite = LightB;
			Source.enabled = false;
			EffectL.gameObject.SetActive (false);
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			LightSpr.sprite = LightR;
			Source.enabled = true;
			EffectL.gameObject.SetActive (true);
		}
	}
}