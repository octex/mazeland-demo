using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLight : MonoBehaviour {

	public SpriteRenderer Spr;
	public Material Normal;
	public Material Diffuse;

	void Start () 
	{
		
	}


	void Update () 
	{
		
	}
	void OnCollisionExit2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			Spr.material = Diffuse;
		}
	}
	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.tag == "Player") 
		{
			Spr.material = Normal;
		}
	}
}
