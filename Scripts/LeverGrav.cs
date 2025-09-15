using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverGrav : MonoBehaviour 
{
	public GameObject Mother;
	public GameObject Player;
	private bool touch;
	private bool active;
	public SpriteRenderer LeverGravSpr;
	public Sprite LeverOffR;
	public Sprite LeverOnR;
	public Sprite LeverOffB;
	public Sprite LeverOnB;
	private int GravOption;
	public AudioSource Effect;
	public GameObject TargetMove;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		Player.GetComponent<Player> ();
		Effect.GetComponent<AudioSource> ();
		GravOption = 0;
	}

	void Update () 
	{
		if (GravOption == 0) 
		{
			Player.GetComponent<Player> ().gravD = "down";
			Mother.GetComponent<Mother> ().MainCameraObj.orthographicSize = 90;
			//Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation = Quaternion.Euler (0,0,0);
			Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
			Player.GetComponent<Player> ().rotValue.w = 1;
			TargetMove.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		else if(GravOption == 1)
		{
			Player.GetComponent<Player> ().gravD = "up";
			Mother.GetComponent<Mother> ().MainCameraObj.orthographicSize = 90;
			//Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation = Quaternion.Euler (0,0,-180);
			Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,-180);
			Player.GetComponent<Player> ().rotValue.w = 0;
			TargetMove.transform.rotation = Quaternion.Euler (0, 0, 180);
		}
		/*else if(GravOption == 1)
		{
			Player.GetComponent<Player> ().gravD = "left";
			Mother.GetComponent<Mother> ().MainCameraObj.orthographicSize = 125;
			Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation = Quaternion.Euler (0,0,-90);
			Player.GetComponent<Player> ().transform.rotation = Quaternion.Euler (0,0,-90);
		}
		else if(GravOption == 2)
		{
			Player.GetComponent<Player> ().gravD = "up";
			Mother.GetComponent<Mother> ().MainCameraObj.orthographicSize = 100;
			Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation = Quaternion.Euler (0,0,-180);
			Player.GetComponent<Player> ().transform.rotation = Quaternion.Euler (0,0,-180);
		}
		else if(GravOption == 3)
		{
			Player.GetComponent<Player> ().gravD = "right";
			Mother.GetComponent<Mother> ().MainCameraObj.orthographicSize = 125;
			Mother.GetComponent<Mother> ().MainCameraObj.transform.rotation = Quaternion.Euler (0,0,90);
			Player.GetComponent<Player> ().transform.rotation = Quaternion.Euler (0,0,90);
		}*/
		/*if (touch == true)
		{
			Effect.Play ();
			if (active == false) 
			{
				active = true;
			}
			else if (active == true) 
			{
				active = false;
			}
			if (GravOption < 1) 
			{
				GravOption++;
			}
			else if (GravOption >= 1)
			{
				GravOption = 0;
			}
		}*/
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1 && active == false) 
		{
			LeverGravSpr.sprite = LeverOffB;	
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2 && active == false) 
		{
			LeverGravSpr.sprite = LeverOffR;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1 && active == true) 
		{
			LeverGravSpr.sprite = LeverOnB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2 && active == true) 
		{
			LeverGravSpr.sprite = LeverOnR;
		}
	}

	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			if (touch == false)
			{
				Effect.Play ();
				touch = true;
				if (active == false)
				{
					active = true;
				}
				else if (active == true)
				{
					active = false;
				}
				if (GravOption < 1) 
				{
					GravOption++;
				}
				else if (GravOption >= 1)
				{
					GravOption = 0;
				}
			}
		}
	}
	void OnCollisionExit2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			touch = false;
		}
	}
}
