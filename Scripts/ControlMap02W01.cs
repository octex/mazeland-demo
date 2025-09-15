using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMap02W01 : MonoBehaviour
{
	public GameObject Mother;

	public GameObject plt1;
	public GameObject plt3;				//IMPULSER

	public GameObject plt4;	//X
	public GameObject plt5; //Y

	public GameObject plt6; //X 30-60

	public GameObject plt7;//ACT en Black
	public GameObject plt8;//76-36

	public GameObject plt9;

	public GameObject plt10; //Y 66- -30

	public GameObject plt11;
	public GameObject plt12Orb;

	public GameObject plt13;
	public GameObject plt14;

	public GameObject pltimpulserV;
	private string Vstate;
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
				if (plt1.transform.localPosition.x > -183)
				{
					plt1.GetComponent<Rigidbody2D>().velocity = Vector2.left * 150;	
				}
				else
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt3.transform.localPosition.x > -135) //IZQ  -88  -135
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.left * 150;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 2) 
			{
				if (plt4.transform.localPosition.x < 12)
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.right * 150;	
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt5.transform.localPosition.y > 21)
				{
					plt5.GetComponent<Rigidbody2D>().velocity = Vector2.down * 150;	
				}
				else
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
				if (plt6.transform.localPosition.y > 30)
				{
					plt6.GetComponent<Rigidbody2D>().velocity = Vector2.down * 150;	
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 4)
			{
				if (plt7.transform.localPosition.y > -16)
				{
					plt7.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt7.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt8.transform.localPosition.y > 36)
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 5)
			{
				if(plt9.transform.localPosition.y > -6)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 6)
			{
				//-30
				if (plt10.transform.localPosition.y > -30)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 150;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 7)
			{
				if(plt11.transform.localPosition.x > 120)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if(plt11.transform.localPosition.x < -21)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
				if(plt12Orb.transform.localPosition.x > 160)
				{
					plt12Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 200;
				}
				else if(plt12Orb.transform.localPosition.x < -60)
				{
					plt12Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 200;
				}
			}
			else if (chamber == 8)
			{
				//150 R -55  L
				if (plt13.transform.localPosition.x > -3)
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt14.transform.localPosition.x > 150)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if (plt14.transform.localPosition.x < -55)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
			}
			else if(chamber == 9)
			{
				pltimpulserV.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
			}
			else if (chamber == 10)
			{
			}
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			if (chamber == 1) 
			{
				if (plt1.transform.localPosition.x < -138)
				{
					plt1.GetComponent<Rigidbody2D>().velocity = Vector2.right * 150;	
				}
				else
				{
					plt1.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt3.transform.localPosition.x < -88) //IZQ  -88  -135
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.right * 150;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 2) 
			{
				if (plt4.transform.localPosition.x > -50)
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.left * 150;	
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt5.transform.localPosition.y < 56)
				{
					plt5.GetComponent<Rigidbody2D>().velocity = Vector2.up * 150;	
				}
				else
				{
					plt5.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
				if (plt6.transform.localPosition.y < 60)
				{
					plt6.GetComponent<Rigidbody2D>().velocity = Vector2.up * 150;	
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 4)
			{
				if(plt7.transform.localPosition.y < 22)
				{
					plt7.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt7.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt8.transform.localPosition.y < 76)
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt8.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 5)
			{
				if(plt9.transform.localPosition.y < 62)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 6)
			{
				if (plt10.transform.localPosition.y < 66)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 150;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 7)
			{
				if(plt11.transform.localPosition.x > 120)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 200;
				}
				else if(plt11.transform.localPosition.x < -21)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 200;
				}

				if(plt12Orb.transform.localPosition.x > 160)
				{
					plt12Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if(plt12Orb.transform.localPosition.x < -60)
				{
					plt12Orb.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
			}
			else if (chamber == 8)
			{
				if (plt14.transform.localPosition.x > 150)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else if (plt14.transform.localPosition.x < -55)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}

				if (plt13.transform.localPosition.x < 145)
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
				else
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

			}
			else if(chamber == 9)
			{
				if (Vstate == "down")
				{
					pltimpulserV.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 100;
				}
				else if(Vstate == "up")
				{
					pltimpulserV.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 100;
				}

				if (pltimpulserV.transform.localPosition.y > 100)
				{
					pltimpulserV.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 100;
					Vstate = "down";
				}
				else if(pltimpulserV.transform.localPosition.y < 4)
				{
					pltimpulserV.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 100;
					Vstate = "up";
				}
			}
			else if (chamber == 10)
			{
			}
		}
	}
}