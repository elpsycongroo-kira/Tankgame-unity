using UnityEngine;
using System.Collections;

public class movel : MonoBehaviour {
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
	public Vector3 count;
	private float magnitude1;
	private float magnitude2;
	// Use this for initialization
	int i;
	Ray ray;
	RaycastHit hit;
	void Start () {

		//A=Finalpoint-Intialpoint;
		if (PlayerPrefs.GetInt ("tshape") == 1) {
			//transform.position=new Vector3(98.f,822.7f,-301.9f);
			transform.localPosition=new Vector3(8.2f,0,-19.7f);
		}
		//if (PlayerPrefs.GetInt ("commander") == 0) {
			//transform.position=new Vector3(98.2f,822.7f,-301.9f);
			//Tank= GameObject.FindGameObjectWithTag("arjun");
			//tankmain = Tank.GetComponent<Rigidbody>() ;
		//}
		if (PlayerPrefs.GetInt ("troop1") == 0) {
			gameObject.SetActive(false);
		
		}
		//offsetl = transform.position-tankmain.transform.position ;
		//magnitude1 = offsetl.magnitude;
		//tank.transform.position = instanciateobjectonclick.path[0] + offsetl;
		//magnitude = offsetl.magnitude;
		//offsetl = offsetl / magnitude;
//		tank.transform.rotation = tank_movement.tank_rotation;
		}

}