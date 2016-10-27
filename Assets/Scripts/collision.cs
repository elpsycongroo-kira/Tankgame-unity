using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {
	public GameObject pop;
	popup p;
	public static int river_turbidity;
	public static int threshold_turbidity=8;
	private int treecollision=0;
	private int watercollision=0;
	private int housecollision=0;
	//public static int rcol=0;
	// Use this for initialization
	void Start () {

		//Debug.Log ("ENTER COLLISION");
		p = pop.GetComponent<popup>();
		//Debug.Log ("collison srupt");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*void OnCollisionEnter(Collision coll)
	{
		//Debug.Log ("hasdasd");
		if (coll.gameObject.name == "Test 2_x0_y0") {
			tank_movement.fpath.Add (transform.position);
			p.c1 =1;

			p.SendMessage ("hit with "+coll.gameObject.name);
			//	Debug.Log ("print enter collision");
			//Debug.Log (coll.gameObject.name + "collided with tree");
		}
	}
*/
	void OnTriggerEnter(Collider coll) {
		//Debug.Log ("collisiiosdj" + coll.name);

		if (coll.gameObject.name == "house") {
			housecollision++;
			PlayerPrefs.SetInt("housecollision",housecollision);
			Debug.Log ("hereaddedtofpathhouse");
			tank_movement.fpath.Add (transform.position);
			p.c1 = 1;
			p.SendMessage1("hit with "+coll.gameObject.tag);
			//Debug.Log ("House collided");

		}

		if (coll.name == "Test 2_x0_y0") {
			treecollision++;
			//countforcol++;

			PlayerPrefs.SetInt("treecollision",treecollision);
			Debug.Log ("addedtofpthtree");
			tank_movement.fpath.Add (transform.position);
				p.c1 =1;
			p.SendMessage1 ("hit with "+coll.gameObject.name);
			//	Debug.Log ("print enter collision");
			//Debug.Log (coll.name + "collided with tree");
		}
		if (coll.tag== "field") {
			popup.c2 = 1;
			popup.field = 1;
			//treecollision++;
			//PlayerPrefs.SetInt("treecollision",treecollision);
			Debug.Log ("hereaddedtofpathfield");
			tank_movement.fpath.Add (transform.position);
			p.c1 =1;
			p.SendMessage1 ("hit with field cost = 1000/-  hit contiue or redraw");
			//	Debug.Log ("print enter collision");
			//Debug.Log (coll.name + "collided with tree");
		}
		if (coll.tag == "river") {
			popup.c = 1;
			Debug.Log ("hitwith river");
			watercollision++;
			PlayerPrefs.SetInt("watercollision",watercollision);

			Debug.Log ("hereaddedtofpath");
			tank_movement.fpath.Add (transform.position);
			popup.decision=1;
			p.c1 =1;
			river_turbidity = Random.Range (1,15);
			p.SendMessage1 ("turbidity_threshold "+threshold_turbidity+"river_turbidity"+river_turbidity);
			//	Debug.Log ("print enter collision");
			//Debug.Log (coll.name + "collided with tree");
		}
	


		//Debug.Log (coll.name + " collised with tank" + this.name);
	}



}
