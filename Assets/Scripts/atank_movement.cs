using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class atank_movement : MonoBehaviour {
	public  List<Vector3> position1 = new List<Vector3>();
	public static List<Vector3> fpath = new List<Vector3>();
	Vector3 ip,fp;
	public static int i=0;
	int k=instanciateobjectonclick.enemy.Count;
	int o ;
	int flag =0 ;
	public  int stop=0; 
	private GameObject camera;
	float cam = 12f;
	public GameObject enemyfire;
	private Vector3 A;
	void Start()
	{
		if (PlayerPrefs.GetInt ("commander") == 1) {
			gameObject.SetActive(false);
		}
		Debug.Log ("YOu are in start");
		enemyfirestart ();

		transform.position = instanciateobjectonclick.path [0];
		Debug.Log ("starting point" + instanciateobjectonclick.path [0]);
		i = 0;
		A = instanciateobjectonclick.path [1] - instanciateobjectonclick.path [0];
		//Debug.Log ("asdfghjklsdfghjkl;sdfghjklsdfghjkl");
		Debug.Log(PlayerPrefs.GetInt("tshape").ToString());

	}


	void enemyfirestart(){
		if (flag == 0) {
			for (o = 0; o < k; o++) {
				//Debug.Log ("Fire Nikli");
				GameObject obj = Instantiate (enemyfire, instanciateobjectonclick.enemy [o], Quaternion.identity) as GameObject;
			}
			flag++;
		}
	}


	void FixedUpdate () {
		if (PlayerPrefs.GetInt ("commander") == 1) {
			gameObject.SetActive(false);

		}
		if (stop==0){
		if (instanciateobjectonclick.move) {
			if (i < instanciateobjectonclick.path.Count) {
				ip = instanciateobjectonclick.path [i];
				fp = instanciateobjectonclick.path [i + 1];
				//Debug.Log (ip + "shi hai");
				//Debug.Log (fp);
				if (Mathf.Abs (Vector3.Distance (transform.position, fp)) > 0.1f) {
					//transform.Translate ((fp - ip) * Time.deltaTime * 0.1f);
					Vector3 newpos = transform.position; 
					newpos.y = Terrain.activeTerrain.SampleHeight (transform.position);
					transform.position = newpos;
						fpath.Add (newpos);
					transform.position = Vector3.MoveTowards (transform.position, fp, Time.deltaTime * 12);
					A = instanciateobjectonclick.path [i+1] - instanciateobjectonclick.path [i];
					var newrotation = Quaternion.LookRotation(-1*A).eulerAngles;
					newrotation.x = 0;
					newrotation.z = 0;
					transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (newrotation), Time.deltaTime);

					

				} else
					i++;
					if (i == instanciateobjectonclick.path.Count) {
						fpath.Add (transform.position);
					}
		
				}	if((flag==0 )&&(k!=0))
				enemyfirestart ();
		}
			
		

	}
	}
}