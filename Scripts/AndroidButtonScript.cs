using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AndroidButtonScript : MonoBehaviour 
{
	public GameObject Mother;
	public Image render;
	public Sprite R;
	public Sprite B;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			render.sprite = B;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			render.sprite = R;
		}
	}
}
