using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W1config : MonoBehaviour
{
	public GameObject GD;
	public GameObject select1;
	public Text mapName;
	public Text minRecord;
	public Text secRecord;

	void Start ()
	{
		GD.GetComponent<GeneralSaveData> ();
		select1.GetComponent<select> ();
	}
	//70 - 30
	void Update ()
	{
		if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().map01)
		{
			mapName.text = "World 01 - Map 01\nBasic";	
			minRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsMi1().ToString();
			secRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsSec1().ToString();
		}
		else if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().map02)
		{
			mapName.text = "World 01 - Map 02\nImpulsers";
			minRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsMi2().ToString();
			secRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsSec2().ToString();
		}
		else if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().map03)
		{
			mapName.text = "World 01 - Map 03\nGrav Maps";
			minRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsMi3().ToString();
			secRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsSec3().ToString();
		}
		else if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().map04)
		{
			mapName.text = "World 01 - Map 04\nTricks n' traps";
			minRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsMi4().ToString();
			secRecord.text = GD.GetComponent<GeneralSaveData> ().GetRecordsSec4().ToString();
		}
		else if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().map05)
		{
			mapName.text = "World 01 - Map 05\nSoldier of chaos";
			minRecord.text = "N";
			secRecord.text = "O";
		}
		else if (select1.GetComponent<select> ().optionSprite == select1.GetComponent<select> ().MapLocked)
		{
			mapName.text = "Locked";
			minRecord.text = "--";
			secRecord.text = "--";
		}
	}
}
