using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript1 : MonoBehaviour {

	public AudioSource EffectDoor;
	public GameObject Player;
	public string LevelName;

	void Start () 
	{
		Player.GetComponent<Player> ();	
	}

	void Update () 
	{

	}
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			SceneManager.LoadScene (LevelName);
		}
	}
}