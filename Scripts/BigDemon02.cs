using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDemon02 : MonoBehaviour
{
	public GameObject trapsUp, trapsDown, TAUP, TADOWN, Player;
	public MonoBehaviour BossP;
	public string trapSide;

	void Start () 
	{
		BossP.GetComponent<BigDemon> ();
		Player.GetComponent<Player> ();
		//InvokeRepeating ("NormalSkull",1.0f,2.0f);
		InvokeRepeating ("Traps",3.0f,3.0f);
		//InvokeRepeating ();
		trapSide = "down";
	}

	void Update ()
	{
		if (BossP.GetComponent<BigDemon> ().patron == "tercero" || BossP.GetComponent<BigDemon> ().patron == "sexto" || BossP.GetComponent<BigDemon> ().patron == "noveno")
		{
			CancelInvoke ("Traps");
			if (this.gameObject.GetComponent<BigDemon> ().SHAKIN == true)
			{
				trapsDown.SetActive (true);
			}
			else
			{
				trapsDown.SetActive (false);
			}
		}
		if (BossP.GetComponent<BigDemon> ().patron == "segundo" || BossP.GetComponent<BigDemon> ().patron == "quinto" || BossP.GetComponent<BigDemon> ().patron == "octavo")
		{
			if (this.gameObject.GetComponent<BigDemon> ().SHAKIN == true)
			{
				if (trapSide == "down")
				{
					Player.GetComponent<Player> ().gravD = "down";
					Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
					Player.GetComponent<Player> ().rotValue.w = 1;
					trapsUp.SetActive (true);
					trapsDown.SetActive (false);
				}
				else if(trapSide == "up")
				{
					Player.GetComponent<Player> ().gravD = "up";
					Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,-180);
					Player.GetComponent<Player> ().rotValue.w = 0;
					trapsUp.SetActive (false);
					trapsDown.SetActive (true);
				}
			}
			else
			{
				trapsUp.SetActive (false);
				trapsDown.SetActive (false);
			}
		}
	}

	void Traps()
	{
		this.gameObject.GetComponent<BigDemon> ().ChangeState ("BigDemonHit");
		if (trapSide == "up")
		{
			trapSide = "down";
			ChangeStateAdminUp ("Traps01");
		}
		else if (trapSide == "down")
		{
			trapSide = "up";
			ChangeStateAdminDown ("Traps01");
		}
	}
	void Traps02()
	{
		this.gameObject.GetComponent<BigDemon> ().ChangeState ("BigDemonHit");
		ChangeStateAdminDown ("Traps01");
		trapSide = "down";
	}

	void LinealSkull()
	{
		BossP.GetComponent<BigDemon> ().SummonGhostLSpawn();
	}

	void LinealSkull02()
	{
		BossP.GetComponent<BigDemon> ().SummonGhostLSpawn02();
	}

	void NormalSkull()
	{
		BossP.GetComponent<BigDemon> ().SummonGhost ();
	}

	public void ChangeStateAdminUp( string state )
	{
		if (state != null)
		{
			TAUP.GetComponent<Animator> ().Play (state);
		}
	}

	public void ChangeStateAdminDown( string state )
	{
		if (state != null)
		{
			TADOWN.GetComponent<Animator> ().Play (state);
		}
	}
}
