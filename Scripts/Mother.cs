using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Mother : MonoBehaviour
{
	public Color color1 = Color.red, color2 = Color.black;
	public Camera MainCameraObj;
	public Vector3 Rot;
	public GameObject GameOverMenu, WinMenu, GeneralData, Select, PauseMenu;
	/*public Button NextMap;
	public Button Reset;
	public Button Menu;*/
	//public Transform MainCamera;
	//public Vector3 myPos = new Vector3 (0, 0, -1);
	//public Transform PlayerObj;
	public Animator FogA;
	public int currentWorld, currentMap;
	public string mapID;

	void Start () 
	{
		MainCameraObj.GetComponent<Camera> ();
		GeneralData.GetComponent<GeneralSaveData> ();
		MainCameraObj.clearFlags = CameraClearFlags.SolidColor;
		MainCameraObj.backgroundColor = color2;
		MainCameraObj.transform.rotation = Quaternion.Euler(0,0,0);
		GeneralData.GetComponent<GeneralSaveData> ().world = currentWorld;
		GeneralData.GetComponent<GeneralSaveData> ().map = currentMap;
	}
	void Update () 
	{
		Rot = MainCameraObj.transform.rotation.eulerAngles;
		//MainCamera.position = PlayerObj.position + myPos;
	}

	public void MenoPause()
	{
		if (GeneralData.GetComponent<GeneralSaveData> ().PauseGame == true)
		{
			PauseMenu.SetActive (true);
			Select.SetActive (true);
			Select.GetComponent<select> ().Pause = true;
		}
		else
		{
			PauseMenu.SetActive (false);
			Select.SetActive (false);
			Select.GetComponent<select> ().Pause = false;
		}
	}

	public void UpdateStateFog( string state = null)
	{
		if (state != null) 
		{
			FogA.Play (state);
		}
	}
	public void RealGameOver()
	{
		//UpdateStateFog ("FogAlphaToBlack");
		GameOverMenu.SetActive(true);
		Select.SetActive (true);
		Select.GetComponent<select> ().GameOver = true;
	}
	public void LoadWinM()
	{
		//UpdateStateFog ("FogAlphaToBlack");
		WinMenu.SetActive(true);
		Select.SetActive (true);
		Select.GetComponent<select> ().Win = true;
	}
	public void LoadAnyMap ()
	{
		SceneManager.LoadScene (mapID);
	}
	public void ResetMap()
	{
		//Advertisement.Show ();
		Scene scene1 = SceneManager.GetActiveScene ();
		SceneManager.LoadScene (scene1.name);
	}

	public void PlayFogMap()
	{
		FogA.gameObject.GetComponent<FogScript> ().function = "LoadAnyMap";
		FogA.Play ("FogAlphaToBlack");
	}
	public void PlayFogReset()
	{
		FogA.gameObject.GetComponent<FogScript> ().function = "ResetMap";
		FogA.Play ("FogAlphaToBlack");
	}
}