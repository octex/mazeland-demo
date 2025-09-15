using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulserV : MonoBehaviour
{
	public GameObject Mother;
	public GameObject Player;
	//public SpriteRenderer ImpulserVSpr;
	//public Sprite ImpulserR;
	//public Sprite ImpulserB;
	public GameObject ps01;
	public GameObject ps02;
	public BoxCollider2D collider;
	public float Force;
	public float newX;
	public float currentX;
	private bool Ctouch;
	public string Side, constSide;
	public bool onActive;
	public int caseX;
	//40 -190
	void Start ()
	{
		Mother.GetComponent<Mother> ();
		Player.GetComponent<Player> ();
	}
		
	void Update ()
	{
		if (Side == "right")
		{
			ps01.transform.localScale = new Vector3 (1, 1, -1);
			ps01.transform.localPosition = new Vector3 (newX,ps01.transform.localPosition.y,ps01.transform.localPosition.z);
			ps02.transform.localScale = new Vector3 (1, 1, -1);
			ps02.transform.localPosition = new Vector3 (newX,ps02.transform.localPosition.y,ps02.transform.localPosition.z);
		}
		else if (Side == "left")
		{
			ps01.transform.localScale = new Vector3 (1, 1, 1);
			ps01.transform.localPosition = new Vector3 (currentX,ps01.transform.localPosition.y,ps01.transform.localPosition.z);
			ps02.transform.localScale = new Vector3 (1, 1, 1);
			ps02.transform.localPosition = new Vector3 (currentX,ps02.transform.localPosition.y,ps02.transform.localPosition.z);
		}
		if (onActive == false)
		{
			if(caseX == 0)
			{
				if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
				{
					Side = "right";
				}
				else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
				{
					Side = "left";
				}
			}
			else if(caseX == 1)
			{
				if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
				{
					Side = "left";
				}
				else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
				{
					Side = "right";
				}
			}
		}
		else
		{
			Side = constSide;
			if (caseX == 0)
			{
				if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
				{
					ps01.SetActive (true);
					ps02.SetActive (true);
					collider.enabled = true;
				}
				else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
				{
					ps01.SetActive (false);
					ps02.SetActive (false);
					collider.enabled = false;
				}
			}
			else if(caseX == 1)
			{
				if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1)
				{
					ps01.SetActive (false);
					ps02.SetActive (false);
					collider.enabled = false;
				}
				else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2)
				{
					ps01.SetActive (true);
					ps02.SetActive (true);
					collider.enabled = true;
				}
			}
		}
		if (Ctouch == true)
		{
			if (Side == "right")
			{
				Player.GetComponent<Player>().rb2d.AddForce(new Vector2(Force,0));
			}
			else if (Side == "left") 
			{
				Player.GetComponent<Player>().rb2d.AddForce(new Vector2(-Force,0));	
			}
		}
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "Player")
		{
			Ctouch = true;
		}
	}
	void OnTriggerExit2D( Collider2D other )
	{
		if (other.gameObject.tag == "Player")
		{
			Ctouch = false;
		}
	}
}
