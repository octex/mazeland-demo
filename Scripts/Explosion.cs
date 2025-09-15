using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

	public Animator ExpAnim;
	public GameObject us;

	void Start () 
	{
		
	}

	void Update () 
	{
		
	}
	void Kill()
	{
		Destroy (us);
	}
	public void ExpState (string state)
	{
		if (state != null) 
		{
			ExpAnim.Play (state);
		}
	}
}
