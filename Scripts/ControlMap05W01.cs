using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMap05W01 : MonoBehaviour {

	public GameObject Mother;
	public int chamber = 1;
	/*public GameObject Timer;
	public GameObject plt1;
	public GameObject plt2;
	public GameObject plt3;
	public GameObject plt4;
	public GameObject plt5;
	public GameObject plt6;
	public GameObject plt7;
	public GameObject plt8;
	public GameObject plt9;
	public GameObject plt10;
	public GameObject plt11;
	public GameObject plt12;
	public GameObject plt13;
	public GameObject plt14;
	public GameObject plt15;
	public GameObject plt16;
	public GameObject plt17;
	public GameObject plt18;
	public GameObject plt19;
	public GameObject plt20;*/

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		//Timer.GetComponent<Boss01Timer> ();
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			/*if (Timer.GetComponent<Boss01Timer> ().sec == 0 && Timer.GetComponent<Boss01Timer> ().min == 0)
			{
				plt1.SetActive (true);
				plt2.SetActive (true);
			}*/
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			/*plt1.SetActive (false);
			plt2.SetActive (false);*/
		}
	}
}