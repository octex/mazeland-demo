using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMap01W01 : MonoBehaviour {

	public GameObject Mother;
	public GameObject plt1;

	public GameObject plt2;

	public GameObject plt3;

	public GameObject plt4;
	public GameObject plt5;

	public GameObject plt6;

	public GameObject plt9;
	public GameObject plt10;
	public GameObject plt11;

	public GameObject plt13;

	public GameObject plt14;
	public GameObject plt15;

	public GameObject plt16;
	public GameObject plt17;

	public GameObject plt22;  //Exit
	public GameObject plt23;  //L
	public GameObject plt24;  //R

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
				if (plt1.GetComponent<Rigidbody2D> ().rotation > 5)
				{
					plt1.GetComponent<Rigidbody2D> ().rotation -=5;
				}
			}
			else if (chamber == 2) 
			{
				// 5 Y
				if (plt2.transform.localPosition.y < 5)
				{
					plt2.GetComponent<Rigidbody2D>().velocity = Vector2.up * 100;	
				}
				else
				{
					plt2.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
				//Y 16
				if (plt3.transform.localPosition.y < 16)
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.up * 100;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 4)
			{
				if (plt4.transform.localPosition.y > -50)
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.down * 100;
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				/*30*/ /*-50*/ //plt4.SetActive (false);
				//plt5.SetActive (false);
				if (plt5.GetComponent<Rigidbody2D> ().rotation < 90)
				{
					plt5.GetComponent<Rigidbody2D> ().rotation +=5;
				}
			}
			else if (chamber == 5)
			{
				if (plt6.transform.localPosition.x < 90)
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 150;
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 6)
			{
				if (plt9.transform.localPosition.y < 65)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt10.transform.localPosition.x < 150)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 120;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt11.transform.localPosition.y < 65)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 7)
			{
				if (plt13.transform.localPosition.y > 12)
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//plt13.SetActive (false);
			}
			else if (chamber == 8)
			{
				//55Y - 100Y DER pl14
				//65Y - 100Y IZQ plt15
				if (plt14.transform.localPosition.y < 120)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt15.transform.localPosition.y > 65)
				{
					plt15.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt15.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if(chamber == 9)
			{
				if (plt16.transform.localPosition.x < 105)
				{
					plt16.GetComponent<Rigidbody2D> ().velocity = Vector2.right * 120;
				}
				else
				{
					plt16.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt17.GetComponent<Rigidbody2D> ().rotation < 180)
				{
					plt17.GetComponent<Rigidbody2D> ().rotation += 10;
				}
			}
			else if (chamber == 10)
			{
				if (plt22.transform.localPosition.y < 80)
				{
					plt22.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt22.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt23.transform.localPosition.y > -8 && plt24.transform.localPosition.y > -8)
				{
					plt23.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
					plt24.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt23.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
					plt24.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//62y - -8y plt22
			}
		}
		else if (Mother.GetComponent<Mother> ().MainCameraObj.backgroundColor == Mother.GetComponent<Mother> ().color2) 
		{
			if (chamber == 1)
			{
				if (plt1.GetComponent<Rigidbody2D> ().rotation < 90)
				{
					plt1.GetComponent<Rigidbody2D> ().rotation +=5;
				}
			}
			else if (chamber == 2)
			{
				//-32 Y
				if (plt2.transform.localPosition.y > -32)
				{
					plt2.GetComponent<Rigidbody2D>().velocity = Vector2.down * 100;	
				}
				else
				{
					plt2.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 3)
			{
				//Y -20
				if (plt3.transform.localPosition.y > -20)
				{
					plt3.GetComponent<Rigidbody2D>().velocity = Vector2.down * 100;	
				}
				else
				{
					plt3.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 4)
			{
				if (plt4.transform.localPosition.y < 30)
				{
					plt4.GetComponent<Rigidbody2D>().velocity = Vector2.up * 100;	
				}
				else
				{
					plt4.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt5.GetComponent<Rigidbody2D> ().rotation > 5)
				{
					plt5.GetComponent<Rigidbody2D> ().rotation -=5;
				}
				//plt5.SetActive (true);
			}
			else if (chamber == 5)
			{
				//5X - 90X
				if (plt6.transform.localPosition.x > 5)
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 150;
				}
				else
				{
					plt6.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 6)
			{
				if (plt9.transform.localPosition.y > -2)
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt9.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//plt9.SetActive (true);//IZQ VERTICAL 65 Y  -3 Y
				//plt10.SetActive (false);//HORIZONTAL 66 X - 150 X

				if (plt10.transform.localPosition.x > 66)
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 120;
				}
				else
				{
					plt10.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt11.transform.localPosition.y > -2)
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt11.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//plt11.SetActive (false);//DER VERTICAL 65Y -2.4Y
			}
			else if (chamber == 7)
			{
				if (plt13.transform.localPosition.y < 63)
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;	
				}
				else
				{
					plt13.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if (chamber == 8)
			{
				if (plt14.transform.localPosition.y > 55)
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt14.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}

				if (plt15.transform.localPosition.y < 120)
				{
					plt15.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt15.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
			}
			else if(chamber == 9)
			{
				if (plt16.transform.localPosition.x > 60)
				{
					plt16.GetComponent<Rigidbody2D> ().velocity = Vector2.left * 120;
				}
				else
				{
					plt16.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt17.GetComponent<Rigidbody2D> ().rotation > 10)
				{
					plt17.GetComponent<Rigidbody2D> ().rotation -= 10;
				}
			}
			else if (chamber == 10)
			{
				if (plt22.transform.localPosition.y > 60)
				{
					plt22.GetComponent<Rigidbody2D> ().velocity = Vector2.down * 120;
				}
				else
				{
					plt22.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				if (plt23.transform.localPosition.y < 30 && plt24.transform.localPosition.y < 30)
				{
					plt23.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
					plt24.GetComponent<Rigidbody2D> ().velocity = Vector2.up * 120;
				}
				else
				{
					plt23.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
					plt24.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
				}
				//30 -8
			}
		}
	}
}