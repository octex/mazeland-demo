using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossAnimationControl : MonoBehaviour
{
	public Animator BossAnim;
	public Sprite GreyBase, GreyPlt, BckGrey, Hearts, mouth, bodyG, bodyB,UgR,DgR,RgR,LgR,CgR ,UgB,DgB,RgB,LgB,CgB;
	public GameObject Player,/*upKey,downKey,rightKey,leftKey,*/Ckey,SND, PAUSE,Exit, Plt11, Plt12, Plt13, Plt14,Metrallet,Rock, MetraPlt1, MetraPtl2, Bck,Lever, Base, TextC,  Clock ,Demon, DialogQ, Fog, Traps, plataform01, plataform02, plataform03, plataform04, plt1G, plt2G, plt3G, plt4G, pltB, pltB2, CanvasTxt, pltS1, pltS2, plt2cond;
	public AudioSource soundAnim;
	public AudioClip tense01;
	public AudioClip tense02;
	public AudioClip boom;
	public GameObject Orb, Orb02;
	public BoxCollider2D bx;
	public Text Dialog;

	void Start ()
	{
		BossAnim.GetComponent<Animator> ();
		Demon.GetComponent<BigDemon> ();
	}

	void Update ()
	{
		if (Orb02.gameObject.activeSelf == true)
		{
			Orb02.transform.position += new Vector3 (0,1,0);
		}
		if (Demon.GetComponent<BigDemon> ().patron == "decimo")
		{
			Player.GetComponent<Player> ().HP = 3;
			if (Demon.GetComponent<BigDemon>().died == 0)
			{
				ChangeState ("DemonDye");
				Player.GetComponent<Player> ().PlayerAlive = false;
				Fog.GetComponent<Animator> ().enabled = false;
			}
			pltB.SetActive (false);
			pltB2.SetActive (false);
			plt1G.SetActive (false);
			plt2G.SetActive (false);
			plt3G.SetActive (false);
			plt4G.SetActive (false);
			plt2cond.SetActive (false);
			pltS1.SetActive (false);
			pltS2.SetActive (false);
			Clock.SetActive (false);
			Demon.GetComponent<BigDemon02> ().enabled = false;
			if (Demon.GetComponent<BigDemon>().died == 0)
			{
				Demon.GetComponent<BigDemon> ().ChangeState ("BigDemonDies");
			}
			CanvasTxt.SetActive (false);
			Dialog.gameObject.SetActive (true);
		}
	}

	void FinalDialogue()
	{
		if (Dialog.text == "")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "Please...";
		}
		else if (Dialog.text == "Please...")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "...save us...";
		}
		else if (Dialog.text == "...save us...")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "...find the way to defeat him...";
		}
		else if (Dialog.text == "...find the way to defeat him...")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "...and escape from the darkness.";
		}
		else if (Dialog.text == "...and escape from the darkness.")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "Good luck, Zen";
		}
		else if (Dialog.text == "Good luck, Zen")
		{
			ChangeState ("Orbitation");
		}
	}

	void OnTriggerEnter2D( Collider2D other )
	{
		if (other.gameObject.tag == "Player")
		{
			ChangeState ("FinalBossStartAnim");
			Player.GetComponent<Player> ().PlayerAlive = false;
			ChangeMusic (tense02);
			soundAnim.loop = false;
			soundAnim.Play ();
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void ChangeState (string state)
	{
		if (state != null)
		{
			BossAnim.Play (state);
		}
	}
	void ChangeStateD ()
	{
		ChangeState ("DemonAwakes");
		ChangeMusic (boom);
		soundAnim.loop = false;
		soundAnim.Play ();
		Destroy (Orb);
		bx.enabled = false;
	}
	void ChangeStateD02 ()
	{
		Ckey.GetComponent<AndroidButtonScript> ().R = CgR;
		Ckey.GetComponent<AndroidButtonScript> ().B = CgB;

		/*upKey.GetComponent<AndroidButtonScript> ().R = UgR;
		upKey.GetComponent<AndroidButtonScript> ().B = UgB;

		downKey.GetComponent<AndroidButtonScript> ().R = DgR;
		downKey.GetComponent<AndroidButtonScript> ().B = DgB;

		leftKey.GetComponent<AndroidButtonScript> ().R = LgR;
		leftKey.GetComponent<AndroidButtonScript> ().B = LgB;

		rightKey.GetComponent<AndroidButtonScript> ().R = RgR;
		rightKey.GetComponent<AndroidButtonScript> ().B = RgB;*/

		SND.SetActive (false);
		PAUSE.SetActive (false);
		Orb02.SetActive (true);
		Exit.SetActive (true);
		ChangeState ("FinalBossNoAnim");
		Player.GetComponent<Player> ().PlayerAlive = true;
		Player.GetComponent<Player> ().hearts3R = Hearts;
		Player.GetComponent<Player> ().BodyB = bodyB;
		Player.GetComponent<Player> ().BodyR = bodyG;
		Player.GetComponent<Player> ().MouthR = mouth;
		Base.GetComponent<Platform> ().enabled = false;
		Base.GetComponent<SpriteRenderer>().sprite = GreyBase;
		Bck.GetComponent<SpriteRenderer> ().sprite = BckGrey;
		Traps.SetActive (false);
		plataform01.SetActive (true);
		plataform02.SetActive (true);
		plataform03.SetActive (true);
		plataform04.SetActive (true);
		plataform01.GetComponent<Platform> ().enabled = false;
		plataform01.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		plataform02.GetComponent<Platform> ().enabled = false;
		plataform02.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		plataform03.GetComponent<Platform> ().enabled = false;
		plataform03.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		plataform04.GetComponent<Platform> ().enabled = false;
		plataform04.GetComponent<SpriteRenderer>().sprite = GreyPlt;

		Plt11.GetComponent<Platform> ().enabled = false;
		Plt11.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		Plt12.GetComponent<Platform> ().enabled = false;
		Plt12.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		Plt13.GetComponent<Platform> ().enabled = false;
		Plt13.GetComponent<SpriteRenderer>().sprite = GreyPlt;
		Plt14.GetComponent<Platform> ().enabled = false;
		Plt14.GetComponent<SpriteRenderer>().sprite = GreyPlt;

		Dialog.text = "";
		MetraPlt1.SetActive (false);
		MetraPtl2.SetActive (false);
		Rock.SetActive (false);
		Metrallet.SetActive (false);
		Lever.SetActive (false);
		ChangeMusic (boom);
		soundAnim.loop = false;
		soundAnim.Play ();
		Fog.GetComponent<Animator> ().enabled = true;
	}
	void Text()
	{
		Demon.GetComponent<Platform> ().enabled = false;
		if (Dialog.text == "")
		{
			DialogQ.GetComponent<AudioSource> ().Play();
			Dialog.text = "Are you ready?";
		}
		else if (Dialog.text == "Are you ready?")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "I guess you're not";
		}
		else if(Dialog.text == "I guess you're not")
		{
			DialogQ.GetComponent<AudioSource> ().Play ();
			Dialog.text = "laughs glorified";
			Demon.GetComponent<BigDemon> ().ChangeState("BigDemonLaughs");
		}
		else if(Dialog.text == "laughs glorified")
		{
			Fog.GetComponent<Animator> ().enabled = true;
			DialogQ.GetComponent<AudioSource> ().Play ();
			ChangeState ("BattleIntro");
			Demon.GetComponent<BigDemon> ().ChangeState("BigDemonLaughs");
			Dialog.text = "not really, sounds like a horse";
		}	
	}
	void ChangeMusic (AudioClip newM)
	{
		soundAnim.clip = newM;
	}
	void Checker()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "tercero")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker02()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "cuarto")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker03()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "quinto")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker04()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "sexto")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker05()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "septimo")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker06()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "octavo")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void Checker07()
	{
		if (Demon.GetComponent<BigDemon> ().patron == "noveno")
		{
			ChangeState ("ChangePart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void DisableDialog()
	{
		Player.GetComponent<Player> ().PlayerAlive = true;
		Dialog.text = "";
		pltB.SetActive (true);
		pltB2.SetActive (true);
		pltS1.SetActive (true);
		pltS2.SetActive (true);
		Clock.SetActive (true);
		TextC.SetActive (true);
		plataform01.SetActive (false);
		plataform02.SetActive (false);
		plataform03.SetActive (false);
		plataform04.SetActive (false);
		Dialog.gameObject.SetActive (false);
		Fog.GetComponent<Animator> ().enabled = true;
		DialogQ.SetActive (false);
		Traps.SetActive (true);
		CanvasTxt.SetActive (true);
		if (Demon.GetComponent<BigDemon> ().patron == "segundo")
		{
			ChangeState ("SecondPart");
			Fog.GetComponent<Animator> ().enabled = false;
		}
	}
	void SecondPart()
	{
		Fog.GetComponent<Animator> ().enabled = true;
		ChangeState ("FinalBossSecondPart");
		plt1G.SetActive (true);
		plt2G.SetActive (true);
		plt3G.SetActive (true);
		plt4G.SetActive (true);
		pltB.SetActive (false);
		pltB2.SetActive (false);
		pltS1.SetActive (false);
		pltS2.SetActive (false);
		plt2cond.SetActive (true);
		Demon.GetComponent<BigDemon02> ().enabled = true;
	}

	void Third()
	{
		Metrallet.GetComponent<Metrallet> ().newMin = 0;
		Metrallet.GetComponent<Metrallet> ().newSec = 45;
		pltB.SetActive (true);
		pltB2.SetActive (true);
		plt1G.SetActive (false);
		plt2G.SetActive (false);
		plt3G.SetActive (false);
		plt4G.SetActive (false);
		plt2cond.SetActive (true);
		ChangeState ("FinalBossSecondPart 1");
		Player.GetComponent<Player> ().GravMap = false;
		Player.GetComponent<Player> ().gravD = "down";
		Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
		Player.GetComponent<Player> ().rotValue.w = 1;
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().TercerPatron ();
		Fog.GetComponent<Animator> ().enabled = true;
		pltB.GetComponent<BombPlatform> ().speed = 1.2f;
		pltB2.GetComponent<BombPlatform> ().speed = 1.2f;
	}

	void Four()
	{
		pltB.SetActive (true);
		pltB2.SetActive (true);
		plt1G.SetActive (false);
		plt2G.SetActive (false);
		plt3G.SetActive (false);
		plt4G.SetActive (false);
		plt2cond.SetActive (false);
		ChangeState ("FinalBossSecondPart 2");
		Player.GetComponent<Player> ().GravMap = false;
		Player.GetComponent<Player> ().gravD = "down";
		Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
		Player.GetComponent<Player> ().rotValue.w = 1;
		Demon.GetComponent<BigDemon02> ().enabled = false;
		Demon.GetComponent<BigDemon> ().CuartoPatron ();
		Fog.GetComponent<Animator> ().enabled = true;
		pltS1.SetActive (true);
		pltS2.SetActive (true);
	}
	void Five()
	{
		Fog.GetComponent<Animator> ().enabled = true;
		ChangeState ("FinalBossSecondPart 3");
		plt1G.SetActive (true);
		plt2G.SetActive (true);
		plt3G.SetActive (true);
		plt4G.SetActive (true);
		pltB.SetActive (false);
		pltB2.SetActive (false);
		pltS1.SetActive (false);
		pltS2.SetActive (false);
		plt2cond.SetActive (true);
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().QuintoPatron ();
	}
	void Six()
	{
		Metrallet.GetComponent<Metrallet> ().newMin = 1;
		Metrallet.GetComponent<Metrallet> ().newSec = 0;
		pltB.SetActive (true);
		pltB2.SetActive (true);
		plt1G.SetActive (false);
		plt2G.SetActive (false);
		plt3G.SetActive (false);
		plt4G.SetActive (false);
		plt2cond.SetActive (true);
		ChangeState ("FinalBossSecondPart 4");
		Player.GetComponent<Player> ().GravMap = false;
		Player.GetComponent<Player> ().gravD = "down";
		Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
		Player.GetComponent<Player> ().rotValue.w = 1;
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().SextoPatron ();
		Fog.GetComponent<Animator> ().enabled = true;
		pltB.GetComponent<BombPlatform> ().speed = 1.6f;
		pltB2.GetComponent<BombPlatform> ().speed = 1.6f;
	}
	void Seven()
	{
		pltB.SetActive (true);
		pltB2.SetActive (true);
		plt1G.SetActive (false);
		plt2G.SetActive (false);
		plt3G.SetActive (false);
		plt4G.SetActive (false);
		plt2cond.SetActive (false);
		ChangeState ("FinalBossSecondPart 5");
		Player.GetComponent<Player> ().GravMap = false;
		Player.GetComponent<Player> ().gravD = "down";
		Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
		Player.GetComponent<Player> ().rotValue.w = 1;
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().SeptimoPatron ();
		Fog.GetComponent<Animator> ().enabled = true;
		pltS1.SetActive (true);
		pltS2.SetActive (true);
	}
	void Eight()
	{
		Fog.GetComponent<Animator> ().enabled = true;
		ChangeState ("FinalBossSecondPart 6");
		plt1G.SetActive (true);
		plt2G.SetActive (true);
		plt3G.SetActive (true);
		plt4G.SetActive (true);
		pltB.SetActive (false);
		pltB2.SetActive (false);
		pltS1.SetActive (false);
		pltS2.SetActive (false);
		plt2cond.SetActive (true);
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().OctavoPatron ();
	}
	void Nine()
	{
		Metrallet.GetComponent<Metrallet> ().newMin = 1;
		Metrallet.GetComponent<Metrallet> ().newSec = 30;
		pltB.SetActive (true);
		pltB2.SetActive (true);
		plt1G.SetActive (false);
		plt2G.SetActive (false);
		plt3G.SetActive (false);
		plt4G.SetActive (false);
		plt2cond.SetActive (true);
		ChangeState ("FinalBossSecondPart 7");
		Player.GetComponent<Player> ().GravMap = false;
		Player.GetComponent<Player> ().gravD = "down";
		Player.GetComponent<Player> ().rotValue = Quaternion.Euler(0,0,0);
		Player.GetComponent<Player> ().rotValue.w = 1;
		Demon.GetComponent<BigDemon02> ().enabled = true;
		Demon.GetComponent<BigDemon> ().NovenoPatron ();
		Fog.GetComponent<Animator> ().enabled = true;
		pltB.GetComponent<BombPlatform> ().speed = 1.8f;
		pltB2.GetComponent<BombPlatform> ().speed = 1.8f;
	}

	void ChangePatern()
	{
		if(Demon.GetComponent<BigDemon>().patron == "tercero")
		{
			Third ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "cuarto")
		{
			Four ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "quinto")
		{
			Five ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "sexto")
		{
			Six ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "septimo")
		{
			Seven ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "octavo")
		{
			Eight ();
		}
		else if(Demon.GetComponent<BigDemon>().patron == "noveno")
		{
			Nine ();
		}
	}
}