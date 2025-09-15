using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placa : MonoBehaviour 
{
	public GameObject Mother;
	public SpriteRenderer PlacaR;
	public Sprite PlacaRed;
	public Sprite PlacaBlack;
	public Sprite PlacaRedA;
	public Sprite PlacaBlackA;
	public bool placaActive = false;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		PlacaR.GetComponent<SpriteRenderer> ();
	}

	void Update ()
	{
		if (Mother.GetComponent<Mother>().MainCameraObj.backgroundColor == Mother.GetComponent<Mother>().color1 && placaActive == false)
		{
			PlacaR.sprite = PlacaBlack;
		}
		else if (Mother.GetComponent<Mother>().MainCameraObj.backgroundColor == Mother.GetComponent<Mother>().color2 && placaActive == false)
		{
			PlacaR.sprite = PlacaRed;
		}
		if (Mother.GetComponent<Mother>().MainCameraObj.backgroundColor == Mother.GetComponent<Mother>().color1 && placaActive == true)
		{
			PlacaR.sprite = PlacaBlackA;
		}
		else if (Mother.GetComponent<Mother>().MainCameraObj.backgroundColor == Mother.GetComponent<Mother>().color2 && placaActive == true)
		{
			PlacaR.sprite = PlacaRedA;
		}
	}
	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "box")
		{
			placaActive = true;
		}	
	}
	void OnCollisionExit2D (Collision2D other)
	{
		if (other.gameObject.tag == "box")
		{
			placaActive = false;
		}	
	}
}
