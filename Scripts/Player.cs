using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour 
{
	//Sector publico
	public GameObject Mother , Timer , Target , GD;
	public SpriteRenderer Hearts , BodySpr , MouthSpr;
	public Sprite BodyR , BodyB , MouthB , MouthR, MouthBDanger, MouthRDanger, hearts3R, hearts2R , hearts1R , hearts0R , hearts3B, hearts2B , hearts1B , hearts0B;
	public Transform Spawn;
	public int grav , speed;
	public float _x , _y , jumpForce;
	public Color red1 = Color.red, black2 = Color.black;
	public int HP = 3, times = 6;
	public bool touch, WIN, PlayerAlive, GravMap, AntiGravT,AndroidState;
	public Quaternion rotValue = new Quaternion(0, 0, 0, 0);
	public AudioSource Change;
	public AudioSource Death;
	public AudioSource MusicLvl;
	public AudioSource HeartUp;
	public Rigidbody2D rb2d;
	public string gravD;
	public Animator PlayerAnim;
	public ParticleSystem DiePart;


	//Sector privado
	private bool WalkLeft , WalkRight, Jump, usingKey;
	private int i;

	void Start () 
	{
		//PlayerPrefs.DeleteAll ();
		InvokeRepeating("Invul", 0.25f, 0.25f);
		GD.GetComponent<GeneralSaveData> ().PauseGame = false;
		rb2d.GetComponent<Rigidbody2D> ();
		PlayerAnim.GetComponent<Animator> ();
		Mother.GetComponent<Mother> ();
		DiePart.GetComponent<ParticleSystem> ();
		PlayerAlive = true;
		MusicLvl.GetComponent<AudioSource> ();
		Timer.GetComponent<map_time> ();
		//SprBody.GetComponent<SpriteRenderer> ();
	}

	void Update () 
	{
		if (GD.GetComponent<GeneralSaveData> ().PauseGame == true)
		{
			this.gameObject.GetComponent<BoxCollider2D> ().enabled = false;
			rb2d.bodyType = RigidbodyType2D.Static;
		}
		else
		{
			if (times == 0)
			{
				this.gameObject.GetComponent<BoxCollider2D> ().enabled = true;
				rb2d.bodyType = RigidbodyType2D.Dynamic;
			}
		}
		if (transform.rotation != rotValue)
		{
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				MouthSpr.sprite = MouthBDanger;
			}
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				MouthSpr.sprite = MouthRDanger;
			}
		}
		if (AndroidState == true)
		{
			_y = CrossPlatformInputManager.GetAxis ("Vertical");
			_x = CrossPlatformInputManager.GetAxis ("Horizontal");	
		}
		else
		{
			_y = Input.GetAxis ("Vertical");
			_x = Input.GetAxis ("Horizontal");
		}
		var mainDP = DiePart.main;
		if (HP == 3) 
		{
			Hearts.sprite = hearts3R;
		}
		else if (HP == 2) 
		{
			Hearts.sprite = hearts2R;
		}
		else if (HP == 1) 
		{
			Hearts.sprite = hearts1R;
		}
		else if (HP <= 0) 
		{
			PlayerAlive = false;
			//MusicLvl.Stop ();
			if (i == 0) 
			{
				PlayerAnim.enabled = true;
				i = 1;
			}
			UpdateState ("PlayerDead");
			Hearts.sprite = hearts0R;
			mainDP.startColor = Mother.GetComponent<Mother> ().color1;
		}
		if (WIN == true)
		{
			if (i == 0) 
			{
				PlayerAnim.enabled = true;
				i = 1;
			}
			UpdateState ("PlayerWin");
		}
		if (gravD == "up") 
		{
			if (AntiGravT == false) 
			{
				rb2d.gravityScale = -grav;
			}
			else
			{
				rb2d.gravityScale = 0;
			}
		}
		else if (gravD == "down")
		{
			if (AntiGravT == false) 
			{
				rb2d.gravityScale = grav;
			}
			else
			{
				rb2d.gravityScale = 0;
			}
		}
		else if (gravD == "right")
		{
			rb2d.AddForce(Vector2.right * grav);
		}
		else if (gravD == "left") 
		{
			rb2d.AddForce(Vector2.left * grav);
		}
		if (Input.GetKeyDown ("c") && PlayerAlive == true) 
		{
			if (GravMap == true)
			{
				if(gravD == "down")
				{
					gravD = "up";
					rotValue = Quaternion.Euler(0,0,-180);
					rotValue.w = 0;
					Target.transform.rotation = Quaternion.Euler (0, 0, 180);
				}
				else if(gravD == "up")
				{
					gravD = "down";
					rotValue = Quaternion.Euler(0,0,0);
					rotValue.w = 1;
					Target.transform.rotation = Quaternion.Euler (0, 0, 0);
				}
			}
			Change.Play ();
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor = Mother.GetComponent<Mother> ().color2;
			} 
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor = Mother.GetComponent<Mother> ().color1;
			}
		}
	}
	void FixedUpdate()
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			BodySpr.sprite = BodyB;
			MouthSpr.sprite = MouthB;	
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			BodySpr.sprite = BodyR;
			MouthSpr.sprite = MouthR;	
		}
		transform.rotation = rotValue;	
		rb2d.angularVelocity = 0;
		if (gravD == "down" /*&& AndroidState == false*/)
		{
			if (AntiGravT == false)
			{
				rb2d.velocity = new Vector2 (_x * speed, rb2d.velocity.y);	
			}
			else
			{
				rb2d.velocity = new Vector2 (_x * speed, _y * speed);	
			}
		}
		else if (gravD == "up" /*&& AndroidState == false*/)
		{
			if (AntiGravT == false)
			{
				rb2d.velocity = new Vector2 (_x * -speed, rb2d.velocity.y);	
			}
			else
			{
				rb2d.velocity = new Vector2 (_x * -speed, _y * -speed);	
			}
		}
		if (Input.GetKey ("right") && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false || WalkRight == true && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false || CrossPlatformInputManager.GetAxis ("Horizontal") > 0 && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false)
		{
			transform.localScale = new Vector3 (1, 1, 1);
		}
		else if (Input.GetKey ("left") && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false || WalkLeft == true && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false || CrossPlatformInputManager.GetAxis ("Horizontal") < 0 && PlayerAlive == true && GD.GetComponent<GeneralSaveData> ().PauseGame == false)
		{
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		else
		{
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
		}
		if (Input.GetKey ("space") && touch == true && PlayerAlive == true || Jump == true && touch == true && PlayerAlive == true && AntiGravT == false /*|| CrossPlatformInputManager.GetAxis("Vertical") > 0.95 && touch == true && PlayerAlive == true && AntiGravT == false*/) 
		{
			if (gravD == "down")
			{
				//rb2d.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
				//rb2d.velocity = Vector2.up * jumpForce;
				//rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
				rb2d.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
				//rb2d.AddForce (Vector2.up * (y * jumpForce));
			}
			else if(gravD == "up")
			{
				rb2d.AddForce (Vector2.down * jumpForce, ForceMode2D.Impulse);
			}
			else if(gravD == "left")
			{
				rb2d.AddForce (Vector2.right * jumpForce, ForceMode2D.Impulse);
			}
			else if(gravD == "right")
			{
				rb2d.AddForce (Vector2.left * jumpForce, ForceMode2D.Impulse);
			}
		}
	}

	public void UpdateState( string state = null)
	{
		if (state != null) 
		{
			PlayerAnim.Play (state);
		}
	}

	void OnCollisionEnter2D( Collision2D other )
	{
		/*
		if (other.gameObject.tag == "reset_box") 
		{
			Scene scene1 = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene1.name);
		}
else */	if (other.gameObject.tag == "trap" && GD.GetComponent<GeneralSaveData>().PauseGame == false)
		{
			if (GD.GetComponent<GeneralSaveData> ().easyMode == 0)
			{
				HP -= 1;	
			}
			times = 0;
			transform.position = Spawn.position;
			Timer.GetComponent<map_time> ().DeathCounter++;
		}
	}
	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "JumpT") 
		{
			touch = true;
		}
		else if (other.gameObject.tag == "trap" && GD.GetComponent<GeneralSaveData>().PauseGame == false)
		{
			if (GD.GetComponent<GeneralSaveData> ().easyMode == 0)
			{
				HP -= 1;	
			}
			times = 0;
			Timer.GetComponent<map_time> ().DeathCounter++;
			transform.position = Spawn.position;
		}
		else if (other.gameObject.tag == "heart")
		{
			if (HP < 3)
			{
				HP++;
				Destroy (other.gameObject);
				HeartUp.Play ();
			}
		}
		else if(other.gameObject.tag == "AntiGrav")
		{
			AntiGravT = true;
			rb2d.velocity = Vector2.zero;
		}
	}
	void OnTriggerExit2D( Collider2D other )
	{
		if (other.gameObject.tag == "JumpT") 
		{
			touch = false;
		}
		else if(other.gameObject.tag == "AntiGrav")
		{
			AntiGravT = false;
		}
	}
	public void AndroidColorChange()
	{
		Change.Play ();
		if (PlayerAlive == true)
		{
			if (GravMap == true)
			{
				if(gravD == "down")
				{
					gravD = "up";
					rotValue = Quaternion.Euler(0,0,-180);
					rotValue.w = 0;
					Target.transform.rotation = Quaternion.Euler (0, 0, 180);
				}
				else if(gravD == "up")
				{
					gravD = "down";
					rotValue = Quaternion.Euler(0,0,0);
					rotValue.w = 1;
					Target.transform.rotation = Quaternion.Euler (0, 0, 0);
				}
			}
			if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
			{
				Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor = Mother.GetComponent<Mother> ().color2;
			} 
			else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
			{
				Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor = Mother.GetComponent<Mother> ().color1;
			}
		}
	}
	public void LeftControl(int value)
	{
		if (value == 1) 
		{
			WalkLeft = true;
			if (gravD == "down")
			{
				rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
			}
			else if (gravD == "up")
			{
				rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
			}
		} 
		else 
		{
			WalkLeft = false;
		}
	}
	public void RightControl(int value)
	{
		if (value == 1) 
		{
			WalkRight = true;
			if (gravD == "down")
			{
				rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
			}
			else if (gravD == "up")
			{
				rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
			}
		} 
		else 
		{
			WalkRight = false;
		}
	}
	public void JumpControl(int value)
	{
		if (value == 1)
		{
			if (AntiGravT == false)
			{
				Jump = true;	
			}
			else if(AntiGravT == true)
			{
				if (gravD == "down")
				{
					rb2d.velocity = new Vector2 (rb2d.velocity.x, speed);
				}
				else if (gravD == "up")
				{
					rb2d.velocity = new Vector2 (rb2d.velocity.x, -speed);
				}
			}
		} 
		else 
		{
			Jump = false;
		}
	}

	public void DownControl()
	{
		if (AntiGravT == true && gravD == "down")
		{
			rb2d.velocity = new Vector2 (rb2d.velocity.x, -speed);
		}
		else if(AntiGravT == true && gravD == "up")
		{
			rb2d.velocity = new Vector2 (rb2d.velocity.x, speed);
		}
	}

	public void LoadGameOver()
	{
		Death.Play ();
		Mother.GetComponent<Mother> ().RealGameOver ();
		PlayerAnim.enabled = false;
	}
	public void LoadWin()
	{
		Mother.GetComponent<Mother> ().LoadWinM ();
		PlayerAnim.enabled = false;
	}

	public void Invul()
	{
		if (times < 4)
		{
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
			rb2d.bodyType = RigidbodyType2D.Static;
			rb2d.velocity = Vector2.left * 140;
			speed = 0;
			times++;
			if (BodySpr.enabled == false && MouthSpr.enabled == false && Hearts.enabled == false)
			{
				Hearts.enabled = true;
				BodySpr.enabled = true;
				MouthSpr.enabled = true;
			}
			else if (BodySpr.enabled == true && MouthSpr.enabled == true && Hearts.enabled == true)
			{
				Hearts.enabled = false;
				BodySpr.enabled = false;
				MouthSpr.enabled = false;
			}
		}
		else
		{
			speed = 140;
			this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
			rb2d.bodyType = RigidbodyType2D.Dynamic;
		}
	}
}