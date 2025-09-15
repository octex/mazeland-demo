using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour 
{
	public GameObject Game1;
	public SpriteRenderer R;
	public Sprite BlackP;
	public Sprite RedP;

	void Start () 
	{
		Game1.GetComponent<Mother> ();
	}
	void Update () 
	{
		if (Game1.GetComponent<Mother> ().MainCameraObj.backgroundColor == Game1.GetComponent<Mother>().color1)
		{
			R.sprite = BlackP;
		} 
		else if (Game1.GetComponent<Mother> ().MainCameraObj.backgroundColor == Game1.GetComponent<Mother>().color2) 
		{
			R.sprite = RedP;
		}
	}
}
