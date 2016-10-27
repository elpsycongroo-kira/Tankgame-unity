using UnityEngine;
using System.Collections;
//using System.IO.Ports;

public class arduino : MonoBehaviour
{
	public GameObject turet;
	rotation r;
	public GameObject bullet;
	shoot s;
//	SerialPort sp = new SerialPort("COM6", 9600);

	void Start()
	{
//		sp.Open();
//		sp.ReadTimeout = 1;
		s = bullet.GetComponent<shoot>();
		r = turet.GetComponent<rotation>();
	}

	void Update()
	{
		try
		{

//			Debug.Log(sp.ReadLine());
//			sp.WriteLine("");
			//  if(sp.ReadLine=="1")
		}
		catch (System.Exception)
		{

		}
	}
}

