using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class presentationControl : MonoBehaviour
{
	public bool AndroidState;
	public Text indications;
	bool touched;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (AndroidState == true)
		{
			indications.text = "Press here to skip";
		}
		else
		{
			indications.text = "Press ESC to skip";
			if (Input.GetKey (KeyCode.Escape))
			{
				LoadMenu ();	
			}
		}
	}
	public void LoadMenu()
	{
		SceneManager.LoadScene ("menu");
	}
}
