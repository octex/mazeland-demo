using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigDemon : MonoBehaviour
{
	[SerializeField] private Text HPshow;
	public GameObject Mother, Heart;
	public AudioSource laugh;
	public SpriteRenderer Head;
	public Sprite HeadR;
	public Sprite HeadB;
	public Sprite HeadRL;
	public Sprite HeadBL;
	public Transform Player;
	public Transform GhostSpawn;
	public Transform BombSpawn;
	public Transform BombSpawn02;
	public float BossHP;
	public string patron;
	public GameObject Ghost;
	public GameObject Bomb;
	public GameObject Bomb02;
	public Transform Camera;
	public Animator BDAnimate;
	public Collider2D PlayerCollider;
	public bool SHAKIN;
	public float ActX, ActY, ActZ;
	public MonoBehaviour BD2;
	public int died = 0;

	private float shake;
	public float shakeAmount;
	private float decrease;

	void Start ()
	{
		shake = 1.0f;
		shakeAmount = 5.0f;
		decrease = 0.1f;
		Mother.GetComponent<Mother> ();
		Ghost.GetComponent<Ghost> ();
		Bomb.GetComponent<Bomb> ();
		Bomb02.GetComponent<Bomb> ();
		BDAnimate.GetComponent<Animator> ();
		Head.GetComponent<SpriteRenderer> ();
		//if (patron == "primero") 
		//{
		InvokeRepeating ("SummonGhost", 6.0f, 5.0f);
		//InvokeRepeating ("SummonGhostLSpawn", 6.0f, 5.0f);
		InvokeRepeating ("SummonBomb", 2.0f, 4.0f);
		InvokeRepeating ("SummonBomb02", 4.0f, 6.5f);
		InvokeRepeating ("SummonHeart", 0.5f, 8.0f);
		//}
		//else if (patron == "segundo") 
		//{
		//	InvokeRepeating ("SummonGhost", 1.5f, 2.0f);
		//	InvokeRepeating ("SummonBomb", 3.0f, 4.5f);
		//	InvokeRepeating ("SummonBomb02", 5.0f, 6.5f);
		//}
	}
	void Update () 
	{
		HPshow.text = "HP: "+BossHP;
		if (patron == "decimo")
		{
			CancelInvoke ("SummonGhost");
			CancelInvoke ("SummonBomb");
			CancelInvoke ("SummonBomb02");
			CancelInvoke ("SummonHeart");
			this.gameObject.GetComponent<BigDemon02> ().CancelInvoke ("Traps02");
			this.gameObject.GetComponent<BigDemon02> ().CancelInvoke ("Traps");
		}
		Debug.Log (patron);
		Ghost.GetComponent<Ghost>().Mother = Mother;
		Bomb.GetComponent<Bomb> ().Mother = Mother;
		Bomb02.GetComponent<Bomb> ().Mother = Mother;
		Bomb.transform.position = BombSpawn.position;
		Bomb02.transform.position = BombSpawn02.position;

		if (SHAKIN == false)
		{
			Camera.localPosition = new Vector3(70,-1,-10);
		}
		else
		{
			var Pos = new Vector3(ActX,ActY,ActZ);
			Camera.localPosition = (Random.insideUnitSphere + Pos) * shakeAmount;
		}

		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			Head.sprite = HeadB;
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			Head.sprite = HeadR;
		}

		//PATRONES EN BASE AL HP//
		if (BossHP <= 1000 && BossHP > 900) 
		{
			patron = "primero";
		}
		else if (BossHP <= 900 && BossHP > 800) 
		{
			patron = "segundo";
			CancelInvoke ("SummonBomb");
			CancelInvoke ("SummonBomb02");
			CancelInvoke ("SummonGhost");
		}
		else if (BossHP <= 800 && BossHP > 700) 
		{
			patron = "tercero";
		}
		else if (BossHP <= 700 && BossHP > 600) 
		{
			patron = "cuarto";
		}
		else if (BossHP <= 600 && BossHP > 500) 
		{
			patron = "quinto";
			CancelInvoke ("SummonBomb");
			CancelInvoke ("SummonBomb02");
		}
		else if (BossHP <= 500 && BossHP > 400) 
		{
			patron = "sexto";
		}
		else if (BossHP <= 400 && BossHP > 300) 
		{
			patron = "septimo";
		}
		else if (BossHP <= 300 && BossHP > 200) 
		{
			patron = "octavo";
			CancelInvoke ("SummonBomb");
			CancelInvoke ("SummonBomb02");
		}
		else if (BossHP <= 200 && BossHP > 100) 
		{
			patron = "noveno";
		}
		else if (BossHP <= 100 && BossHP > 1) 
		{
			patron = "decimo";
		}
	}
	public void SummonGhost()
	{
		if (patron == "primero" || patron == "cuarto" || patron == "septimo")
		{
			ChangeState ("BigDemonSummon");
		}
		Instantiate (Ghost);
		Ghost.transform.position = new Vector2(GhostSpawn.position.x, Player.position.y + 10);
	}
	void SummonGhostL( float Y )
	{
		ChangeState ("BigDemonSummon");
		Instantiate (Ghost);
		Ghost.transform.localPosition = new Vector2(GhostSpawn.localPosition.x, Y);
	}
	void SummonHeart()
	{
		if (Player.gameObject.GetComponent<Player> ().HP < 3)
		{
			Instantiate (Heart);	
		}
		Heart.transform.localPosition = new Vector3 (Random.Range(-80f,46f),-38,0);//-135 46
	}
	public void SummonGhostLSpawn()
	{
		if (patron == "segundo" || patron == "tercero" || patron == "cuarto")
		{
			//SummonGhostL (0.0f);
			//SummonGhostL (50.0f);
			SummonGhostL (60.0f);
			SummonGhostL (40.0f);
			SummonGhostL (20.0f);
			SummonGhostL (0.0f);
			//SummonGhostL (-60.0f);
			//SummonGhostL (-120.0f);
			//SummonGhostL (-70.0f);
		}
	}
	public void SummonGhostLSpawn02()
	{
		if (patron == "segundo" || patron == "tercero" || patron == "cuarto")
		{
			//SummonGhostL (0.0f);
			//SummonGhostL (50.0f);
			SummonGhostL (-70.0f);
			SummonGhostL (-50.0f);
			SummonGhostL (-30.0f);
			SummonGhostL (-10.0f);
			//SummonGhostL (-120.0f);
			//SummonGhostL (-70.0f);
		}
	}
	void SummonBomb()
	{
		//ChangeState ("BigDemonSummon");
		Instantiate (Bomb);
	}
	void SummonBomb02()
	{
		//ChangeState ("BigDemonSummon");
		Instantiate (Bomb02);
	}
	public void Shake()
	{
		SHAKIN = true;
	}
	public void NoShake()
	{
		SHAKIN = false;
	}
	public void ChangeState (string state)
	{
		if (state != null) 
		{
			BDAnimate.Play (state);
		}
	}
	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "bullet")
		{
			BossHP -= 20.0f;
			ChangeState ("BigDemonHurt");
		}
	}

	void SpriteLaugh()
	{
		if (Head.sprite == HeadB || Head.sprite == HeadR)
		{
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				Head.sprite = HeadBL;
			}
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				Head.sprite = HeadRL;
			}
		}
		else if (Head.sprite == HeadBL || Head.sprite == HeadRL)
		{
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				Head.sprite = HeadB;
			}
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				Head.sprite = HeadR;
			}
		}
	}
	void PlayLaugh()
	{
		laugh.Play ();
	}
	public void TercerPatron()
	{
		int i = 0;
		if (i == 0)
		{
			this.gameObject.GetComponent<BigDemon02> ().InvokeRepeating ("Traps02",4.0f, 8.0f);
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",5.0f,4.0f);
			CancelInvoke ("SummonBomb");
			InvokeRepeating ("SummonBomb",1.5f,3.5f);
			CancelInvoke ("SummonBomb02");
			InvokeRepeating ("SummonBomb02",3.5f,5.5f);
			i = 1;
		}
	}
	public void CuartoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			this.gameObject.GetComponent<BigDemon02> ().CancelInvoke("Traps02");
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",4.5f,4.0f);
			CancelInvoke ("SummonBomb");
			InvokeRepeating ("SummonBomb",1.0f,3.5f);
			CancelInvoke ("SummonBomb02");
			InvokeRepeating ("SummonBomb02",3.0f,5.0f);
			i = 1;
		}
	}
	public void QuintoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			this.gameObject.GetComponent<BigDemon02> ().InvokeRepeating ("Traps",2.0f,4.0f);
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",4.0f,2.5f);
		}
	}
	public void SextoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",3.0f,3.0f);
			CancelInvoke ("SummonBomb");
			InvokeRepeating ("SummonBomb",0.5f,2.5f);
			CancelInvoke ("SummonBomb02");
			InvokeRepeating ("SummonBomb02",2.0f,4.0f);
			this.gameObject.GetComponent<BigDemon02> ().InvokeRepeating ("Traps02",3.0f,6.0f);
			i = 1;
		}
	}
	public void SeptimoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",2.0f,2.5f);
			CancelInvoke ("SummonBomb");
			InvokeRepeating ("SummonBomb",0.5f,2.0f);
			CancelInvoke ("SummonBomb02");
			InvokeRepeating ("SummonBomb02",1.0f,3.5f);
			this.gameObject.GetComponent<BigDemon02> ().CancelInvoke ("Traps02");
			i = 1;
		}
	}
	public void OctavoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			this.gameObject.GetComponent<BigDemon02> ().InvokeRepeating ("Traps",3.0f,2.0f);
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",1.0f,6.0f);
		}
	}
	public void NovenoPatron()
	{
		int i = 0;
		if (i == 0)
		{
			CancelInvoke ("SummonGhost");
			InvokeRepeating ("SummonGhost",1.0f,2.0f);
			CancelInvoke ("SummonBomb");
			InvokeRepeating ("SummonBomb",1.25f,3.0f);
			CancelInvoke ("SummonBomb02");
			InvokeRepeating ("SummonBomb02",3.0f,4.0f);
			this.gameObject.GetComponent<BigDemon02> ().CancelInvoke ("Traps02");
			this.gameObject.GetComponent<BigDemon02> ().InvokeRepeating ("Traps02",3.0f,5.0f);
			i = 1;
		}
	}
	void Sumar1()
	{
		died = 1;
	}
}