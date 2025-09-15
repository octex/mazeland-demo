using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
	public GameObject GeneralData , Mother, Player;
	public SpriteRenderer Snd;
	public Sprite SndON, SndOFF;
	bool Mt;
	public bool inGame , W1;
	bool ESC = false;

	void Start ()
	{
		Mother.GetComponent<Mother> ();
		GeneralData.GetComponent<GeneralSaveData> ();
		Player.GetComponent<Player> ();
		Mt = false;
	}

	void Update ()
	{
		if (Player.GetComponent<Player> ().PlayerAlive == true)
		{
			inGame = true;
		}
		else
		{
			inGame = false;
		}
		if (inGame == true)
		{
			if (Input.GetKey (KeyCode.Escape) && ESC == false)
			{
				if (GeneralData.GetComponent<GeneralSaveData> ().PauseGame == false)
				{
					GeneralData.GetComponent<GeneralSaveData> ().PauseGame = true;
					Mother.GetComponent<Mother> ().MenoPause ();
				}
				else if (GeneralData.GetComponent<GeneralSaveData> ().PauseGame == true)
				{
					GeneralData.GetComponent<GeneralSaveData> ().PauseGame = false;
					Mother.GetComponent<Mother> ().MenoPause ();
				}
				if (W1 == true)
				{
					Mother.GetComponent<Mother> ().PlayFogMap ();
					Mother.GetComponent<Mother> ().mapID = "menu";
				}
				ESC = true;
			}
			else if (!Input.GetKey (KeyCode.Escape))
			{
				ESC = false;
			}
		}
		else
		{
			if (Input.GetKey (KeyCode.Escape) && ESC == false)
			{
				if (W1 == true)
				{
					Mother.GetComponent<Mother> ().PlayFogMap ();
					Mother.GetComponent<Mother> ().mapID = "menu";
				}
				ESC = true;
			}
			else if (!Input.GetKey (KeyCode.Escape))
			{
				ESC = false;
			}
		}
		if (GeneralData.GetComponent<GeneralSaveData> ().mute == false)
		{
			Snd.sprite = SndON;
		}
		else if (GeneralData.GetComponent<GeneralSaveData> ().mute == true)
		{
			Snd.sprite = SndOFF;
		}
		if (Input.GetKey (KeyCode.M) && Mt == false)
		{
			Mt = true;
			if (GeneralData.GetComponent<GeneralSaveData> ().mute == false)
			{
				GeneralData.GetComponent<GeneralSaveData> ().mute = true;
			}
			else if (GeneralData.GetComponent<GeneralSaveData> ().mute == true)
			{
				GeneralData.GetComponent<GeneralSaveData> ().mute = false;;
			}
		}
		else if(!Input.GetKey (KeyCode.M))
		{
			Mt = false;
		}
	}
}
