using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginButton : MonoBehaviour 
{
	public GameObject MenuColor;
	public Button esteBotonDemierdaaa;
	public Image render;
	public Sprite BeginR;
	public Sprite BeginB;
	public string map01;

	void Start () 
	{
		esteBotonDemierdaaa.GetComponent<Button> ();
		esteBotonDemierdaaa.onClick.AddListener (Empezar);
		//MenuColor.GetComponent<MenuColor> ();
	}

	void Update () 
	{
		/*if (MenuColor.GetComponent<MenuColor> ().MainCameraObj.backgroundColor == MenuColor.GetComponent<MenuColor> ().color1) 
		{
			render.sprite = BeginR;
		}
		else if (MenuColor.GetComponent<MenuColor> ().MainCameraObj.backgroundColor == MenuColor.GetComponent<MenuColor> ().color2) 
		{
			render.sprite = BeginB;
		}*/
	}

	void Empezar()
	{
		SceneManager.LoadScene (map01);
	}
}