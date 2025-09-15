using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss01Timer : MonoBehaviour 
{
	public GameObject Mother, GD;
	public SpriteRenderer ClockSpr;
	public Sprite ClockR;
	public Sprite ClockB;
	public Text MinTxt;
	public Text SecTxt;
	public int min;
	public int sec;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		GD.GetComponent<GeneralSaveData> ();
		ClockSpr.GetComponent<SpriteRenderer> ();
		InvokeRepeating ("ClockBell", 1.0f, 1.0f);
	}

	void Update () 
	{
		MinTxt.text = min.ToString ();
		SecTxt.text = sec.ToString ();
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			ClockSpr.sprite = ClockB;
			MinTxt.color = Mother.GetComponent<Mother> ().color2;
			SecTxt.color = Mother.GetComponent<Mother> ().color2;
		} 
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			ClockSpr.sprite = ClockR;
			MinTxt.color = Mother.GetComponent<Mother> ().color1;
			SecTxt.color = Mother.GetComponent<Mother> ().color1;
		}
	}

	void ClockBell()
	{
		if (GD.GetComponent<GeneralSaveData> ().PauseGame == false)
		{
			if (sec > 0) 
			{
				sec--;
			}
			else if(sec == 0 && min > 0)
			{
				min--;
				sec = 59;
			}
		}
	}
}
