using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyControl1 : MonoBehaviour
{
	public GameObject GeneralData , Mother, Player;
	public Image Snd;
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
			transform.localScale = new Vector3 (0.6f,0.6f,0.5f);
			Snd.sprite = SndON;
			//transform.localScale = new Vector3 (0.6f, 0.6f, 0f);
		}
		else if (GeneralData.GetComponent<GeneralSaveData> ().mute == true)
		{
			
			Snd.sprite = SndOFF;
			transform.localScale = new Vector3 (0.4f,0.6f,0.5f);
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

	public void MuteGame( int pressed )
	{
		if (pressed == 1)
		{
			pressed = 0;
			if (GeneralData.GetComponent<GeneralSaveData> ().mute == false)
			{
				GeneralData.GetComponent<GeneralSaveData> ().mute = true;
			}
			else if (GeneralData.GetComponent<GeneralSaveData> ().mute == true)
			{
				GeneralData.GetComponent<GeneralSaveData> ().mute = false;
			}
		}
	}

	public void PauseGame ( int pressedP )
	{
		if (pressedP == 1 && inGame == true)
		{
			pressedP = 0;
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
		}
	}
}