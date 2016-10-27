using UnityEngine;
using System.Collections;

public class amover : MonoBehaviour {
	public Rigidbody tank;
	public Rigidbody tankmain;
	private GameObject Tank;

	public float speed;
	public float tempt;
	public float flgg = 1;
	public float F2=1;
	public Vector3 speed1;
	public Vector3 A;
	public Vector3 direction;
	public Vector3 cp;
	public Vector3 maxvelocity;
	public Vector3 Intialpoint;
	public Vector3 Finalpoint;
	public float flag=0;
	public float distance;
	public float a;//acceleration
	//public float ax;
	public float Tt;//totaltime
	public float ct=0;//currenttime
	// Use this for initialization
	public Vector3 offsetr; 
	int i;
	Ray ray;
	RaycastHit hit;
	void Start ()
	{

		//A=Finalpoint-Intialpoint;
		if (PlayerPrefs.GetInt ("tshape") == 1) {
			transform.position = new Vector3 (71.5f, 822.7f, -282.7f);
		}

		if (PlayerPrefs.GetInt ("troop2") == 1) {
			gameObject.SetActive (false);

		}
	}
}