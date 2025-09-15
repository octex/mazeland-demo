using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
	public GameObject Player, GD, Game, mapTime, newRecord;
	public Transform Camera;
	public AudioSource Music;
	public bool SHAKIN;
	public Transform target;
	public float ActX;
	public float ActY;
	public float ActZ;

	private float shake;
	private float shakeAmount;
	public float smoothTime = 0.3F;

	private Vector3 velocity = Vector3.zero;

	void Start ()
	{
		GD.GetComponent<GeneralSaveData> ();
		mapTime.GetComponent<map_time> ();
		Game.GetComponent<Mother> ();
		SHAKIN = false;
		Player.GetComponent<Player> ();
		Music.GetComponent<AudioSource> ();
		shake = 1.0f;
		shakeAmount = 5.0f;
	}

	void Update ()
	{
		if (SHAKIN == false)
		{
			Camera.position = Vector3.SmoothDamp (Camera.position, target.transform.position, ref velocity, smoothTime);
			Camera.rotation = Quaternion.Lerp (Camera.rotation, target.transform.rotation, Time.deltaTime * 1.0f);
		}
		else
		{
			var Pos = new Vector3(ActX,ActY,ActZ);
			Camera.position = (Random.insideUnitSphere + Pos) * shakeAmount;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Player.GetComponent<Player> ().PlayerAlive = false;
			Player.GetComponent<Player> ().WIN = true;
			Player.GetComponent<Player> ().rb2d.bodyType = RigidbodyType2D.Static;
			Music.Stop ();
			Invoke ("EndLevel", 3.0f);
			SHAKIN = true;
			if (Game.GetComponent<Mother> ().currentMap == 1)
			{
				GD.GetComponent<GeneralSaveData> ().Unlock02();
				if (GD.GetComponent<GeneralSaveData> ().GetRecordsSec1 () == 0 && GD.GetComponent<GeneralSaveData> ().GetRecordsMi1() == 0)
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords01(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
				else if(mapTime.GetComponent<map_time> ().secV + (mapTime.GetComponent<map_time>().minV * 60) < GD.GetComponent<GeneralSaveData>().GetRecordsSec1 () + (GD.GetComponent<GeneralSaveData>().GetRecordsMi1() * 60))
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords01(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
			}
			else if (Game.GetComponent<Mother> ().currentMap == 2)
			{
				GD.GetComponent<GeneralSaveData> ().Unlock03();
				if (GD.GetComponent<GeneralSaveData> ().GetRecordsSec2 () == 0 && GD.GetComponent<GeneralSaveData> ().GetRecordsMi2() == 0)
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords02(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
				else if(mapTime.GetComponent<map_time> ().secV + (mapTime.GetComponent<map_time>().minV * 60) < GD.GetComponent<GeneralSaveData>().GetRecordsSec2 () + (GD.GetComponent<GeneralSaveData>().GetRecordsMi2() * 60))
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords02(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
			}
			else if (Game.GetComponent<Mother> ().currentMap == 3)
			{
				GD.GetComponent<GeneralSaveData> ().Unlock04();
				if (GD.GetComponent<GeneralSaveData> ().GetRecordsSec3 () == 0 && GD.GetComponent<GeneralSaveData> ().GetRecordsMi3() == 0)
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords03(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
				else if(mapTime.GetComponent<map_time> ().secV + (mapTime.GetComponent<map_time>().minV * 60) < GD.GetComponent<GeneralSaveData>().GetRecordsSec3 () + (GD.GetComponent<GeneralSaveData>().GetRecordsMi3() * 60))
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords03(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
			}
			else if (Game.GetComponent<Mother> ().currentMap == 4)
			{
				GD.GetComponent<GeneralSaveData> ().Unlock05();
				if (GD.GetComponent<GeneralSaveData> ().GetRecordsSec4 () == 0 && GD.GetComponent<GeneralSaveData> ().GetRecordsMi4() == 0)
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords04(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
				else if(mapTime.GetComponent<map_time> ().secV + (mapTime.GetComponent<map_time>().minV * 60) < GD.GetComponent<GeneralSaveData>().GetRecordsSec4 () + (GD.GetComponent<GeneralSaveData>().GetRecordsMi4() * 60))
				{
					newRecord.SetActive (true);
					GD.GetComponent<GeneralSaveData> ().SaveRecords04(mapTime.GetComponent<map_time> ().secV,mapTime.GetComponent<map_time> ().minV);
				}
			}
		}
	}
	void EndLevel()
	{
		
	}
}
