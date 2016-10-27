using UnityEngine;
using System.Collections;

public class amovel : MonoBehaviour {
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
	public Vector3 offsetl; 
	// Use this for initialization
	int i;
	Ray ray;
	RaycastHit hit;
	void Start () {

		//A=Finalpoint-Intialpoint;
		if (PlayerPrefs.GetInt ("tshape") == 1) {
			transform.position=new Vector3(98.2f,822.7f,-301.9f);
		}

		if (PlayerPrefs.GetInt ("troop1") == 1) {
			gameObject.SetActive(false);
		
		}
	
	}
}
