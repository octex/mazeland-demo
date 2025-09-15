using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour 
{

	public GameObject Mother;
	public GameObject Us;

	void Start () 
	{
		Mother.GetComponent<Mother> ();	
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			Us.SetActive (true);
		} 
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			Us.SetActive (false);
		}
	}
}
