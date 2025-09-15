using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
	public GameObject GD;
	public AudioSource Sound;
	public float originalV;

	void Start ()
	{
		GD.GetComponent<GeneralSaveData> ();	
	}

	void Update ()
	{
		if (GD.GetComponent<GeneralSaveData> ().mute == false)
		{
			for (float b = 0; b < originalV; b++)
			{
				if (Sound.volume < originalV)
				{
					Sound.volume += 0.1f;	
				}
			}
		}
		else if (GD.GetComponent<GeneralSaveData> ().mute == true)
		{
			for (float i = originalV; i > 0; i--)
			{
				Sound.volume -= 0.1f;
			}
		}
	}
}
