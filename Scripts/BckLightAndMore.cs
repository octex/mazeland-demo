using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BckLightAndMore : MonoBehaviour
{
	public GameObject Mother;
	public SpriteRenderer BckSpr;
	public Sprite BckB;
	public Sprite BckR;
	//public ParticleSystem EffectL1;
	//public ParticleSystem EffectL2;
	//public ParticleSystem EffectL3;

	void Start ()
	{
		Mother.GetComponent<Mother> ();
	}

	void Update ()
	{
		//var main1 = EffectL1.main;
		//var main2 = EffectL2.main;
		//var main3 = EffectL3.main;

		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			//main1.startColor = Mother.GetComponent<Mother> ().color2;
			//main2.startColor = Mother.GetComponent<Mother> ().color2;
			//main3.startColor = Mother.GetComponent<Mother> ().color2;
			BckSpr.sprite = BckB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			BckSpr.sprite = BckR;
			//main1.startColor = Mother.GetComponent<Mother> ().color1;
			//main2.startColor = Mother.GetComponent<Mother> ().color1;
			//main3.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}
}
