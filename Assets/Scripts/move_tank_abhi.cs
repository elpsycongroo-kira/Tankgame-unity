using UnityEngine;
using System.Collections;

public class move_tank_abhi : MonoBehaviour {

	public Vector3 p1;
	public Vector3 p2;
	public Vector3 p3;
	public Vector3 p4;
	public Vector3 p5;
	private Vector3 target;
	// Use this for initialization
	void Start () {
		transform.position = p1;
		Debug.Log ("game starts");
		target = p2;
	//	Debug.Log (Terrain.activeTerrain.name);// + " \t " + Terrain.activeTerrain.SampleHeight (transform.position));
	//	Debug.Log (Terrain.activeTerrain.SampleHeight(transform.position));//
	}

	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, Time.deltaTime * 20);

		Vector3 newpos = transform.position; 
		newpos.y = Terrain.activeTerrain.SampleHeight (transform.position) ;
		//Debug.Log ("terrain height " + Terrain.activeTerrain.SampleHeight (transform.position));
		//Debug.Log (newpos);
		transform.position = newpos;

		Debug.Log ("target = "+target);
		if (transform.position.x == p2.x && transform.position.z == p2.z) {

			target = p3;		}

		else if (transform.position.x == p3.x && transform.position.z == p3.z) {


			target = p4;		}

		else if (transform.position.x == p4.x && transform.position.z == p4.z) {

			target = p5;
		}
		else if (transform.position.x == p5.x && transform.position.z == p5.z) {

			Debug.Log ("game neds");	
		}


	}
}
