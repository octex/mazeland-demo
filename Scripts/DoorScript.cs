using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour 
{
	public GameObject Lever;
	public Animator DoorAnim;

	void Start () 
	{
		Lever.GetComponent<Lever> ();
		DoorAnim.GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Lever.GetComponent<Lever> ().active == true) 
		{
			ChangeAnim ("DoorOn");
		}
		else if (Lever.GetComponent<Lever> ().active == false)
		{
			ChangeAnim ("DoorOff");
		}
	}
	public void ChangeAnim (string state)
	{
		if (state != null) 
		{
			DoorAnim.Play (state);
		}
	}
}