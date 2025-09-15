using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsAdmin : MonoBehaviour
{
	public GameObject BigDemon;

	void Start ()
	{
		BigDemon.GetComponent<BigDemon> ();
	}

	void Update ()
	{
	}

	void Shake()
	{
		BigDemon.GetComponent<BigDemon> ().Shake ();
	}

	void NoShake()
	{
		BigDemon.GetComponent<BigDemon> ().NoShake ();
	}
}
