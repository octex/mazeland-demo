using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mountainsMenu : MonoBehaviour
{
	public GameObject Camera , Target, Select;
	public float speed = 0.3f , smoothTime = 0.3F;
	public RawImage mnt;
	public Text tut;
	private string text_t , empty = " ";
	int i = 0;
	public bool AndroidState;

	private Vector3 velocity = Vector3.zero;

	void Start ()
	{
		Select.GetComponent<select> ();
		InvokeRepeating ("TutOnOff", 2f, 2f);
		InvokeRepeating ("TutText",4f,4f);
		if (AndroidState == false)
		{
			text_t = "Press ENTER to select";
		}
		else
		{
			text_t = "Better on PC!";
		}
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape))
		{
			Target.transform.localPosition = new Vector3 (-8,Target.transform.localPosition.y,Target.transform.localPosition.z);
			Select.GetComponent<select> ().Menu = true;
			Select.GetComponent<select> ().World = false;
		}
		if (Select.GetComponent<select> ().beginInt == 1)
		{
			Select.GetComponent<select> ().beginInt = 0;
			Select.GetComponent<select> ().Menu = false;
			Select.GetComponent<select> ().World = true;
			BeginGame ();
		}
		Camera.transform.position = Vector3.SmoothDamp (Camera.transform.position, Target.transform.position, ref velocity, smoothTime);
		float speedF = speed * Time.deltaTime;
		mnt.uvRect = new Rect (mnt.uvRect.x + speedF, 0f, 1f, 1f);
	}
	void TutOnOff()
	{
		if (tut.text == text_t)
		{
			tut.text = empty;
		}
		else
		{
			tut.text = text_t;
		}
	}
	void TutText()
	{
		if (text_t == "Better on PC!")
		{
			text_t = "I know, controls sucks";
		}
		else if(text_t == "I know, controls sucks")
		{
			text_t = "If I were you, I would rate 1 star";
		}
		else if(text_t == "If I were you, I would rate 1 star")
		{
			text_t = "But I'm not you...";
		}
		else if(text_t == "But I'm not you...")
		{
			text_t = "...SO SHARE THE DAMN GAME";
		}
		else if(text_t == "...SO SHARE THE DAMN GAME")
		{
			text_t = ".";
		}
		else if(text_t == ".")
		{
			text_t = "Sorry, I'm so stressed";
		}
		else if(text_t == "Sorry, I'm so stressed")
		{
			text_t = "Please click on BEGIN and leave me alone";
		}
		else if(text_t == "Please click on BEGIN and leave me alone")
		{
			text_t = ">:(";
		}


		if (text_t == "Press ENTER to select")
		{
			text_t = "M to enable/disable sound";
		}
		else if(text_t == "M to enable/disable sound")
		{
			text_t = "ESC is for pause and going back";	
		}
		else if(text_t == "ESC is for pause and going back")
		{
			text_t = "Good luck ;)";
		}
		else if(text_t == "Good luck ;)")
		{
			if (i == 1)
			{
				text_t = "Press ENTER to select";
			}
			else
			{
				text_t = "...";
			}
		}
		else if(text_t == "...")
		{
			text_t = "Seriously... start now";
		}
		else if(text_t == "Seriously... start now")
		{
			text_t = "There's nothing else here";
		}
		else if(text_t == "There's nothing else here")
		{
			text_t = "I will limit you here because this is uncomfortable";
		}
		else if(text_t == "I will limit you here because this is uncomfortable")
		{
			text_t = "I'm doing it...";
		}
		else if(text_t == "I'm doing it...")
		{
			text_t = "I guess I'll get back with my gates...";
		}
		else if(text_t == "I guess I'll get back with my gates...")
		{
			text_t = "I MEAN GAMES* sorry... back to work";
			i = 1;
		}
		else if(text_t == "I MEAN GAMES* sorry... back to work" && i == 1)
		{
			text_t = "Press ENTER to select";
		}
	}
	void BeginGame()
	{
		Target.transform.localPosition = new Vector3 (315,Target.transform.localPosition.y,Target.transform.localPosition.z);
	}
}