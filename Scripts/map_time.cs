using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map_time : MonoBehaviour
{
	public GameObject Mother , Player , GD;
	public Text min , sec , minM, secM , DeathCount;
	public int minV = 0 , secV = 0 , DeathCounter = 0;
	public SpriteRenderer BaseSpr;
	public Sprite BaseR , BaseB;

	void Start ()
	{
		GD.GetComponent<GeneralSaveData> ();
		Mother.GetComponent<Mother> ();
		Player.GetComponent<Player> ();
		InvokeRepeating ("Timer", 1.0f, 1.0f);
	}

	void Update ()
	{
		if (Player.GetComponent<Player> ().HP <= 0 || Player.GetComponent<Player>().WIN == true)
		{
			CancelInvoke ("Timer");
		}
		min.text = minV.ToString();
		sec.text = secV.ToString();
		minM.text = minV.ToString();
		secM.text = secV.ToString();
		DeathCount.text = DeathCounter.ToString ();
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
		{
			BaseSpr.sprite = BaseB;
			min.color = Mother.GetComponent<Mother> ().color2;
			sec.color = Mother.GetComponent<Mother> ().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
		{
			BaseSpr.sprite = BaseR;
			min.color = Mother.GetComponent<Mother> ().color1;
			sec.color = Mother.GetComponent<Mother> ().color1;
		}
	}

	void Timer()
	{
		if (GD.GetComponent<GeneralSaveData> ().PauseGame == true)
		{
			secV += 0;
		}
		else
		{
			secV += 1;
		}
		if (secV == 60)
		{
			secV = 0;
			minV += 1;
		}
	}
}
