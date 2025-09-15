using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelDoor : MonoBehaviour 
{
	public GameObject Mother;
	public SpriteRenderer PortalSpr;
	public GameObject Player;
	public Sprite PortalR;
	public Sprite PortalB;
	public ParticleSystem PortalPs;
	public Transform target;
	public Transform MainCamera;
	public float smoothTime = 0.3F;

	private Vector3 velocity = Vector3.zero;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		PortalSpr.GetComponent<SpriteRenderer> ();
		PortalPs.GetComponent<ParticleSystem> ();
		Player.GetComponent<Player> ();
	}

	void Update () 
	{
		var mainPs = PortalPs.main;
		transform.Rotate (0, 0, -250 * Time.deltaTime);
		MainCamera.position = Vector3.SmoothDamp(MainCamera.position, target.transform.position, ref velocity, smoothTime);
		MainCamera.rotation = Quaternion.Lerp (MainCamera.rotation, target.transform.rotation, Time.deltaTime * 1.0f);
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			PortalSpr.sprite = PortalB;
			mainPs.startColor = Mother.GetComponent<Mother> ().color2;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			PortalSpr.sprite = PortalR;
			mainPs.startColor = Mother.GetComponent<Mother> ().color1;
		}
	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Player.GetComponent<Player> ().PlayerAlive = false;
		}
	}
}
