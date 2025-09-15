using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPlatform : MonoBehaviour 
{
	public float speed;
	public string side;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (side == "right")
		{
			transform.position += new Vector3 (speed, 0, 0);
		}
		else if (side == "left")
		{
			transform.position += new Vector3 (-speed, 0, 0);
		}
	}
		
	/*void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "platform") 
		{
			if (side == "right")
			{
				side = "left";
			}
			else if (side == "left")
			{
				side = "right";
			}
		}
	}*/
	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "platform") 
		{
			if (side == "right")
			{
				side = "left";
			}
			else if (side == "left")
			{
				side = "right";
			}
		}
	}
}
