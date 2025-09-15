using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorChamber : MonoBehaviour 
{
	public AudioSource EffectDoor;
	public GameObject Player;
	public GameObject NewLocation;
	public GameObject Spawn;
	public Transform MainCamera;
	public GameObject Game;
	public GameObject prevChamber;
	public GameObject NextChamber;
	public GameObject control;
	public Transform target;
	public float smoothTime = 0.3F;
	public float Xmas = 280.0f;

	private Vector3 velocity = Vector3.zero;

	void Start () 
	{
		Player.GetComponent<Player> ();
		Game.GetComponent<Mother> ();
	}

	void Update () 
	{
		/*if (cameraX <= 280) 
		{
			MainCamera.position += new Vector3(cameraX,0,0);
			Game.transform.position += new Vector3(cameraX,0,0);
		}*/
		//Vector3 targetPosition = target.TransformPoint(new Vector3(48, 20, -88));
		MainCamera.position = Vector3.SmoothDamp(MainCamera.position, target.transform.position, ref velocity, smoothTime);
		MainCamera.rotation = Quaternion.Lerp (MainCamera.rotation, target.transform.rotation, Time.deltaTime * 1.0f);
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//Player.GetComponent<Player> ().times = 0;
			EffectDoor.Play ();
			Player.transform.position = NewLocation.transform.position;
			Player.GetComponent<Player> ().touch = false;
			Game.GetComponent<Mother> ().MainCameraObj.backgroundColor = Game.GetComponent<Mother> ().color2;
			Spawn.transform.position = NewLocation.transform.position;
			Player.GetComponent<Player>().gravD = "down";
			Player.GetComponent<Player> ().rotValue = Quaternion.Euler (0, 0, 0);
			Player.GetComponent<Player> ().rb2d.velocity = Vector2.zero;
			Player.GetComponent<Player> ().AntiGravT = false;
			if (Game.GetComponent<Mother> ().currentWorld == 1 && Game.GetComponent<Mother> ().currentMap == 1)
			{
				control.GetComponent<ControlMap01W01> ().chamber++;
			}
			else if (Game.GetComponent<Mother> ().currentWorld == 1 && Game.GetComponent<Mother> ().currentMap == 2)
			{
				control.GetComponent<ControlMap02W01> ().chamber++;
			}
			else if (Game.GetComponent<Mother> ().currentWorld == 1 && Game.GetComponent<Mother> ().currentMap == 3)
			{
				control.GetComponent<ControlMap03W01> ().chamber++;
			}
			else if (Game.GetComponent<Mother> ().currentWorld == 1 && Game.GetComponent<Mother> ().currentMap == 4)
			{
				control.GetComponent<ControlMap04W01> ().chamber++;
			}
			else if (Game.GetComponent<Mother> ().currentWorld == 1 && Game.GetComponent<Mother> ().currentMap == 5)
			{
				control.GetComponent<ControlMap05W01> ().chamber++;
			}
			target.position += new Vector3 (Xmas, 0, 0);
			target.rotation = Quaternion.Euler (0, 0, 0);
			NextChamber.SetActive (true);
			Destroy (prevChamber);
		}
	}
}