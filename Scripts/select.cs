using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Advertisements;

public class select : MonoBehaviour
{
	public bool AndroidState;
	public GameObject Mother , GeneralData, Target;
	public SpriteRenderer selectSpr01 , selectSpr02 , optionSpr;
	public Sprite optionSprite, selectOff, selectOn, ResetSprite, MenuSprite, ResumeSprite, BeginSprite, QuitSprite, map01, map02, map03, map04, map05, MapLocked, nextMapSprite;
	public int opc , beginInt;
	public string Function , mapToLoad , NextMap;
	public bool moreThan01 , GameOver , Win , Menu , World , W1, Pause;
	private bool touchR = false;
	private bool touchL = false;
	private int currentOpc;

	void Start ()
	{
		currentOpc = 1;
		Mother.GetComponent<Mother> ();
		GeneralData.GetComponent<GeneralSaveData> ();
	}
	bool RetT = false;
	void Update ()
	{
		//PlayerPrefs.DeleteAll ();
		if (currentOpc == opc)
		{
			selectSpr01.gameObject.SetActive (false);
		}
		else
		{
			selectSpr01.gameObject.SetActive (true);
		}
		if (currentOpc == 1)
		{
			selectSpr02.gameObject.SetActive (false);
		}
		else
		{
			selectSpr02.gameObject.SetActive (true);
		}
		optionSpr.sprite = optionSprite;

		if (Input.GetKey (KeyCode.Return) && RetT == false)
		{
			RetT = true;
			Invoke (Function, Time.fixedDeltaTime);
		}
		else if(!Input.GetKey(KeyCode.Return) && AndroidState == false)
		{
			RetT = false;
			if (IsInvoking (Function))
			{
				CancelInvoke (Function);
			}
		}
		if (Pause == true)
		{
			opc = 2;
			if (currentOpc == 1)
			{
				Function = "Resume";
				optionSprite = ResumeSprite;
			}
			else if (currentOpc == 2)
			{
				optionSprite = MenuSprite;
				Function = "LoadMap";
				mapToLoad = "menu";
			}
		}
		if (GameOver == true)
		{
			opc = 2;
			if (currentOpc == 1)
			{
				Function = "Reset";
				optionSprite = ResetSprite;
			}
			else if (currentOpc == 2)
			{
				optionSprite = MenuSprite;
				Function = "LoadMap";
				mapToLoad = "menu";
			}
		}
		if (Win == true)
		{
			opc = 2;
			//Xmin = -85;
			//Xmax = 5;
			if (currentOpc == 1)
			{
				Function = "LoadMap";
				mapToLoad = NextMap;
				optionSprite = nextMapSprite;
			}
			else if (currentOpc == 2)
			{
				Function = "LoadMap";
				mapToLoad = "menu";
				optionSprite = MenuSprite;
			}
		}
		if (Menu == true)
		{
			if (AndroidState == true)
			{
				opc = 1;
			}
			else
			{
				opc = 2;
			}
			if (currentOpc == 1)
			{
				//Begin
				optionSprite = BeginSprite;
				Function = "Begin";
			}
			else if (currentOpc == 2)
			{
				//Quit
				optionSprite = QuitSprite;
				Function = "QuitGame";
			}
		}
		if (World == true) 
		{
			opc = 1;
			Function = "LoadMap";
			mapToLoad = "World01";
		}
		if (W1 == true)
		{
			opc = 5;
			var ulcok02 = GeneralData.GetComponent<GeneralSaveData> ().Unlock02Get("unlock02");
			var ulcok03 = GeneralData.GetComponent<GeneralSaveData> ().Unlock02Get("unlock03");
			var ulcok04 = GeneralData.GetComponent<GeneralSaveData> ().Unlock02Get("unlock04");
			var ulcok05 = GeneralData.GetComponent<GeneralSaveData> ().Unlock02Get("unlockBoss");
			if (currentOpc == 1)
			{
				optionSprite = map01;
				Function = "LoadMap";
				mapToLoad = "World01Map01";
			}
			else if(currentOpc == 2)
			{
				if (ulcok02 == true)
				{
					optionSprite = map02;
					Function = "LoadMap";
					mapToLoad = "World01Map02";
				}
				else
				{
					Function = "Nothing";
					optionSprite = MapLocked;
				}
			}
			else if(currentOpc == 3)
			{
				if (ulcok03 == true)
				{
					optionSprite = map03;
					Function = "LoadMap";
					mapToLoad = "World01Map03";
				}
				else
				{
					Function = "Nothing";
					optionSprite = MapLocked;
				}
			}
			else if(currentOpc == 4)
			{
				if (ulcok04 == true)
				{
					optionSprite = map04;
					Function = "LoadMap";
					mapToLoad = "World01Map04";
				}
				else
				{
					Function = "Nothing";
					optionSprite = MapLocked;
				}
			}
			else if(currentOpc == 5)
			{
				if (ulcok05 == true)
				{
					optionSprite = map05;
					Function = "LoadMap";
					mapToLoad = "World01Map05";
				}
				else
				{
					Function = "Nothing";
					optionSprite = MapLocked;
				}
			}
		}
		//Xn = (Mathf.Abs(Xmin) + Mathf.Abs(Xmax)) / opc;
		if (moreThan01 == true)
		{
			if (Input.GetKey (KeyCode.RightArrow) && /*transform.localPosition.x < (Xmax - Xn) &&*/ touchR == false)
			{
					//transform.position += new Vector3 (Xn, 0f, 0f);
					selectSpr01.sprite = selectOn;
					if (currentOpc < opc)
					{
					
						currentOpc++;
					//optionSpr.material.mainTextureOffset += new Vector2 (1.5f, 0);
					}
				if (currentOpc == opc)
				{
					selectSpr01.gameObject.SetActive (false);
				}
				else
				{
					selectSpr01.gameObject.SetActive (true);
				}
				touchR = true;
			}
			else if (!Input.GetKey (KeyCode.RightArrow))
			{
				touchR = false;
				selectSpr01.sprite = selectOff;
			}
			if (Input.GetKey (KeyCode.LeftArrow) &&/* transform.localPosition.x > (Xmin + Xn) && */touchL == false) 
			{
					//transform.position -= new Vector3 (Xn, 0f, 0f);
					selectSpr02.sprite = selectOn;
					if (currentOpc > 1)
					{
						currentOpc--;
					}
				/*else if (Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation.z == 180)
				{
					transform.position += new Vector3 (Xn, 0f, 0f);
					if (currentOpc < opc)
					{
						currentOpc++;
					}
				}*/
				touchL = true;
			}
			else if (!Input.GetKey (KeyCode.LeftArrow) && AndroidState == false)
			{
				touchL = false;
				selectSpr02.sprite = selectOff;
			}
		}
	}
	void LoadMap ()
	{
		Mother.GetComponent<Mother> ().PlayFogMap ();
		Mother.GetComponent<Mother> ().mapID = mapToLoad;
	}
	void Reset()
	{
		Mother.GetComponent<Mother> ().PlayFogReset ();
	}
	void Begin()
	{
		beginInt = 1;
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
	void Resume()
	{
		GeneralData.GetComponent<GeneralSaveData> ().PauseGame = false;
		Mother.GetComponent<Mother> ().MenoPause ();
	}
	void Nothing()
	{
	}
	public void SELECT(int value)
	{
		Invoke (Function, Time.fixedDeltaTime);
	}
	public void Xbutton ()
	{
		if (Menu == true && World == false)
		{
			QuitGame ();
		}
		else if(World == true && Menu == false)
		{
			Target.transform.localPosition = new Vector3 (-8,Target.transform.localPosition.y,Target.transform.localPosition.z);
			Menu = true;
			World = false;
		}
		else if (World == false && Menu == false && W1 == true)
		{
			Mother.GetComponent<Mother> ().PlayFogMap ();
			Mother.GetComponent<Mother> ().mapID = "menu";
		}
	}
	public void RightA()
	{
		selectSpr01.sprite = selectOn;
		if (currentOpc < opc)
		{
			currentOpc++;
		}
	}
	public void LeftA()
	{
		selectSpr02.sprite = selectOn;
		if (currentOpc > 1)
		{
			currentOpc--;
		}
	}
	public void LeftAoff()
	{
		selectSpr02.sprite = selectOff;
	}
	public void RightAoff()
	{
		selectSpr01.sprite = selectOff;
	}
}
