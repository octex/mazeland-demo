using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMap04W01 : MonoBehaviour
{
	public GameObject Mother;

	public GameObject plt1;
	public GameObject plt3;

	public GameObject plt4;

	public GameObject pltLTop;
	public GameObject pltLTo;
	public GameObject pltL;
	public GameObject pltR;
	public GameObject pltRTo;
	public GameObject pltRTop;

	public GameObject plt5;
	public GameObject Orb;

	public GameObject plt6;
	public GameObject plt7;

	public GameObject plt8;
	public GameObject Impulver;

	public GameObject plt9;
	public GameObject plt10;
	public GameObject plt11; //75  37.5

	public GameObject plt12;

	public GameObject ImpulverII;
	/*public GameObject plt8;
	public GameObject plt9;
	public GameObject plt10;
	public GameObject plt11;
	public GameObject plt12;
	public GameObject plt13;
	public GameObject plt14;
	public GameObject plt15;
	public GameObject plt16;
	public GameObject plt17;
	public GameObject plt18;
	public GameObject plt19;
	public GameObject plt20;*/

	public int chamber;

	void Start () 
	{
		Mother.GetComponent<Mother> ();
		chamber = 1;
	}

	void Update () 
	{
		if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color1) 
		{
			if (chamber == 1) 
			{
				if (plt3.transform.localPosition.y > 10)
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.down * 150;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt1.transform.localPosition.y < 92) //IZQ  -88  -135
				{
					plt1.GetComponent<Rigidbody2D>().velocity = Vector2.up * 150;	
				}
				else
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 2) 
			{
				if (plt4.transform.localPosition.x < 80)//< 80  > -46
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.right * 50;	
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
			}
			else if (chamber == 4)
			{
				if (pltLTop.transform.localPosition.x < 46.1)
				{
					pltLTop.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltLTop.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltLTo.transform.localPosition.x < 46.1)
				{
					pltLTo.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltLTo.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltL.transform.localPosition.x < 46.1)
				{
					pltL.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltL.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				////////////////////////////////////////////////////////////
				if (pltRTop.transform.localPosition.x > 46.1)
				{
					pltRTop.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltRTop.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltRTo.transform.localPosition.x > 46.1)
				{
					pltRTo.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltRTo.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltR.transform.localPosition.x > 46.1)
				{
					pltR.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltR.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

			}
			else if (chamber == 5)
			{
				if (Orb.transform.localPosition.x > 150)
				{
					Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if (Orb.transform.localPosition.x < -60)
				{
					Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
				if (plt5.transform.localPosition.x > 150)
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else if (plt5.transform.localPosition.x < -44)
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
			}
			else if (chamber == 6)
			{
				if (plt6.transform.localPosition.x < 130)
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 50;
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt7.GetComponent<Rigidbody2D>().rotation > 5)
				{
					plt7.GetComponent<Rigidbody2D> ().rotation -= 5;
				}
			}
			else if (chamber == 7)
			{
				if (plt8.transform.localPosition.y < 43.5)
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (Impulver.transform.localPosition.y < -7)
				{
					Impulver.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 100;
				}
				else if(Impulver.transform.localPosition.y > 90)
				{
					Impulver.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 100;
				}
			}
			else if (chamber == 8)
			{
				if (plt9.transform.localPosition.y > 37.5)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt11.transform.localPosition.y > 37.5)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt10.transform.localPosition.y < 75)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if(chamber == 9)
			{
				if (plt12.transform.localPosition.x < 110)//< 80  > -46
				{
					plt12.GetComponent<Rigidbody2D>().velocity = Vector2.right * 30;	
				}
				else
				{
					plt12.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 10)
			{
				if (ImpulverII.transform.localPosition.y < -7)
				{
					ImpulverII.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 35;
				}
				else if(ImpulverII.transform.localPosition.y > 85)
				{
					ImpulverII.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 35;
				}
			}
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			if (chamber == 1) 
			{
				if (plt1.transform.localPosition.y > 10)
				{
					plt1.GetComponent<Rigidbody2D>().velocity = Vector2.down * 150;	
				}
				else
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt3.transform.localPosition.y < 92) //IZQ  -88  -135
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.up * 150;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 2) 
			{
				if (plt4.transform.localPosition.x > -46)//< 80  > -46
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.left * 50;	
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
			}
			else if (chamber == 4)
			{
				if (pltLTop.transform.localPosition.x > -56.3)
				{
					pltLTop.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltLTop.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltLTo.transform.localPosition.x > -22)
				{
					pltLTo.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltLTo.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltL.transform.localPosition.x > 12.3)
				{
					pltL.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else
				{
					pltL.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//////////////////////////////////////////////////////////////////////
				if (pltRTop.transform.localPosition.x < 151.4)
				{
					pltRTop.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltRTop.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltRTo.transform.localPosition.x < 116.5)
				{
					pltRTo.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltRTo.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (pltR.transform.localPosition.x < 81)
				{
					pltR.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
				else
				{
					pltR.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				////////////////////////////////////////////////////////////////////////
			}
			else if (chamber == 5)
			{
				if (Orb.transform.localPosition.x > 150)
				{
					Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if (Orb.transform.localPosition.x < -60)
				{
					Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
				if (plt5.transform.localPosition.x > 150)
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 100;
				}
				else if (plt5.transform.localPosition.x < -44)
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 100;
				}
			}
			else if (chamber == 6)
			{
				if (plt6.transform.localPosition.x > 30)
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 50;
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt7.GetComponent<Rigidbody2D>().rotation < 90)
				{
					plt7.GetComponent<Rigidbody2D> ().rotation += 5;
				}
			}
			else if (chamber == 7)
			{
				if (plt8.transform.localPosition.y > 9)
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (Impulver.transform.localPosition.y < -7)
				{
					Impulver.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 100;
				}
				else if(Impulver.transform.localPosition.y > 90)
				{
					Impulver.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 100;
				}
			}
			else if (chamber == 8)
			{
				if (plt9.transform.localPosition.y < 75)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt11.transform.localPosition.y < 75)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt10.transform.localPosition.y > 37.5)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if(chamber == 9)
			{
				if (plt12.transform.localPosition.x > -54)
				{
					plt12.GetComponent<Rigidbody2D>().velocity = Vector2.left * 30;	
				}
				else
				{
					plt12.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 10)
			{
				if (ImpulverII.transform.localPosition.y < -7)
				{
					ImpulverII.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 35;
				}
				else if(ImpulverII.transform.localPosition.y > 85)
				{
					ImpulverII.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 35;
				}
			}
		}
	}
}