using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundChange : MonoBehaviour 
{
	public RawImage Black;
	public RawImage Red;
	public GameObject Mother;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			Black.gameObject.SetActive (true);
			Red.gameObject.SetActive (false);
		} 
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			Black.gameObject.SetActive (false);
			Red.gameObject.SetActive (true);
		}
	}
}
