using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbScript : MonoBehaviour 
{

	public GameObject Mother;
	public GameObject us;
	public Animator AnimatorOrb;
	public bool Purp;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		AnimatorOrb.GetComponent<Animator> ();
	}

	void Update () 
	{
		if (Purp == false)
		{
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				ChangeAnim ("Orb_red");
			}
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				ChangeAnim ("Orb_black");
			}
		}
		else
		{
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				ChangeAnim ("OrbPurp");
			}
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				ChangeAnim ("OrbPurpB");
			}	
		}
	}

	public void ChangeAnim (string state = null)
	{
		if (state != null)
		{
			AnimatorOrb.Play (state);	
		}
	}
	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			Destroy (us);
		}
	}
}
