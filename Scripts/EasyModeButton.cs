using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasyModeButton : MonoBehaviour
{
	public GameObject General;
	[SerializeField] private Image btn_Sprite;
	[SerializeField] private Sprite btn_On, bt_Off;

	void Start ()
	{
		General.GetComponent<GeneralSaveData> ();
	}

	void Update ()
	{
		if (General.GetComponent<GeneralSaveData>().GetEasyMode() == 0)
			btn_Sprite.sprite = bt_Off;
		else if(General.GetComponent<GeneralSaveData> ().easyMode == 1)
			btn_Sprite.sprite = btn_On;
	}

	public void CheckState(int value)
	{
		if (value == 0)
		{
			if (General.GetComponent<GeneralSaveData> ().GetEasyMode() == 0)
				General.GetComponent<GeneralSaveData> ().SetEasyMode (1);
				Debug.Log ("Llego");
			/*else if(General.GetComponent<GeneralSaveData> ().easyMode == 1)
				General.GetComponent<GeneralSaveData> ().SetEasyMode (0);*/
		}
	}
}
