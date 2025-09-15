using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMap03W01 : MonoBehaviour
{
	public GameObject Mother;

	public GameObject plt1;

	public int chamber;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		chamber = 1;
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			if (chamber == 1) 
			{
			}
			else if (chamber == 2) 
			{
				if (plt1.transform.localPosition.x > 130)
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if(plt1.transform.localPosition.x < -40)
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
			}
			else if (chamber == 3)
			{
			}
			else if (chamber == 4)
			{
			}
			else if (chamber == 5)
			{
			}
			else if (chamber == 6)
			{
			}
			else if (chamber == 7)
			{
			}
			else if (chamber == 8)
			{
			}
			else if(chamber == 9)
			{
			}
			else if (chamber == 10)
			{
			}
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			if (chamber == 1) 
			{
			}
			else if (chamber == 2) 
			{
				if (plt1.transform.localPosition.x > 130)
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if(plt1.transform.localPosition.x < -40)
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
			}
			else if (chamber == 3)
			{
			}
			else if (chamber == 4)
			{
			}
			else if (chamber == 5)
			{
			}
			else if (chamber == 6)
			{
			}
			else if (chamber == 7)
			{
			}
			else if (chamber == 8)
			{
			}
			else if(chamber == 9)
			{
			}
			else if (chamber == 10)
			{
			}
		}
	}
}