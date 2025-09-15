using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalOrbScript : MonoBehaviour
{
	public GameObject Mother;

	void Start ()
	{
		
	}

	void Update ()
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Mother.GetComponent<Mother> ().PlayFogMap ();
			Mother.GetComponent<Mother> ().mapID = "Credits";
		}
	}
}
