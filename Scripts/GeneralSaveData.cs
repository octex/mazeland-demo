using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSaveData : MonoBehaviour 
{
	//public bool winGame;
	//public bool secretEnd;
	//public int orbs;
	//public int godOrbs;
	//public bool necropolis;
	//public bool iceland;
	//public bool temple;
	//public bool jungle;
	public string last;
	public int world, map, easyMode = 0;
	public bool unlock02 , unlock03, unlock04, unlockBoss, mute = false, PauseGame = false;
	public int sec1, sec2, sec3, sec4;
	public int min1, min2, min3, min4;

	public int GetEasyMode ()
	{
		return PlayerPrefs.GetInt ("easyMode", 0);
	}

	public void SetEasyMode (int value)
	{
		PlayerPrefs.SetInt ("easyMode", value);
	}

	public void SaveRecords01(int sec, int min)
	{
		PlayerPrefs.SetInt ("sec1", sec);
		PlayerPrefs.SetInt ("min1", min);
	}

	public void SaveRecords02(int sec, int min)
	{
		PlayerPrefs.SetInt ("sec2", sec);
		PlayerPrefs.SetInt ("min2", min);
	}

	public void SaveRecords03(int sec, int min)
	{
		PlayerPrefs.SetInt ("sec3", sec);
		PlayerPrefs.SetInt ("min3", min);
	}

	public void SaveRecords04(int sec, int min)
	{
		PlayerPrefs.SetInt ("sec4", sec);
		PlayerPrefs.SetInt ("min4", min);
	}

	public void Unlock02()
	{
		PlayerPrefs.SetInt ("unlock02", (true ? 1 : 0 ));
		unlock02 = (PlayerPrefs.GetInt ("unlock02") != 0);
	}

	public bool Unlock02Get (string key)
	{
		int value = PlayerPrefs.GetInt (key);
		if (value == 1)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public void Unlock03()
	{
		PlayerPrefs.SetInt ("unlock03", (true ? 1 : 0));
		unlock03 = (PlayerPrefs.GetInt("unlock03") !=0);
	}

	public void Unlock04()
	{
		PlayerPrefs.SetInt ("unlock04", (true ? 1 : 0));
		unlock04 = (PlayerPrefs.GetInt("unlock04") !=0);
	}

	public void Unlock05()
	{
		PlayerPrefs.SetInt ("unlockBoss", (true ? 1 : 0));
		unlockBoss = (PlayerPrefs.GetInt("unlockBoss") !=0);
	}

	public void SaveRecords()
	{
		PlayerPrefs.SetInt ("sec1", sec1);
		PlayerPrefs.SetInt ("sec2", sec2);
		PlayerPrefs.SetInt ("sec3", sec3);
		PlayerPrefs.SetInt ("sec4", sec4);

		PlayerPrefs.SetInt ("min1", min1);
		PlayerPrefs.SetInt ("min2", min2);
		PlayerPrefs.SetInt ("min3", min3);
		PlayerPrefs.SetInt ("min4", min4);
	}

	public int GetRecordsMi1()
	{
		return PlayerPrefs.GetInt ("min1", 0);
	}
	public int GetRecordsSec1()
	{
		return PlayerPrefs.GetInt ("sec1", 0);
	}

	public int GetRecordsMi2()
	{
		return PlayerPrefs.GetInt ("min2", 0);
	}
	public int GetRecordsSec2()
	{
		return PlayerPrefs.GetInt ("sec2", 0);
	}

	public int GetRecordsMi3()
	{
		return PlayerPrefs.GetInt ("min3", 0);
	}
	public int GetRecordsSec3()
	{
		return PlayerPrefs.GetInt ("sec3", 0);
	}

	public int GetRecordsMi4()
	{
		return PlayerPrefs.GetInt ("min4", 0);
	}
	public int GetRecordsSec4()
	{
		return PlayerPrefs.GetInt ("sec4", 0);
	}

}