using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogScript : MonoBehaviour
{
	public GameObject Mother;
	public string function;

	void Start ()
	{
		Mother.GetComponent<Mother> ();		
	}

	void Update ()
	{
	}

	void SentMsj()
	{
		Mother.SendMessage (function);
	}
}
