using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class instanciateobjectonclick : MonoBehaviour {
	
	Ray ray;
	RaycastHit hit;
	//public GameObject prefab;
	public static List<Vector3> path = new List<Vector3>();
	public static bool move = false;
	public static List<Vector3> enemy = new List<Vector3>();
	public GameObject sphere;
	public GameObject StartMarker;
	public GameObject EndMarker;
	public GameObject tank;
//	public  GameObject tank;
	public static int u=0;
	public static int w = 0;
	string A="asshole";
	private int linenum = 0;
	private int count = 0;
	private int enemycount=0;
	//int w=0;
	/*public void adcurr()
	{
		
		path.Clear ();
		//path.Add (tank.transform.position);
		tank_movement.i = 0;
	}*/
	void Update () {
		//DontDestroyOnLoad (gameObject);
		//DontDestroyOnLoad (sphere);
		//Debug.Log(path[0]);
		ray=Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray,out hit))
		{

			if(Input.GetMouseButtonDown(0))
			{
				//int count = 0;
				if (u == 0) {
					count++;
					if (count < 2) { 	
						GameObject obj = Instantiate (StartMarker, new Vector3 (hit.point.x, hit.point.y+5, hit.point.z), Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
						linenum = 0;
						path.Clear ();
					} else {
						GameObject obj = Instantiate (EndMarker, new Vector3 (hit.point.x, hit.point.y, hit.point.z), Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;
						Vector3 temp2 = new Vector3 (hit.point.x, 5, hit.point.z);
						Vector3 temp1 = path [path.Count - 1];
						temp1.y = 5;
						LineRenderer lineRenderer = GetComponent<LineRenderer> ();
						lineRenderer.SetVertexCount(linenum + 2);
						lineRenderer.SetPosition (linenum, temp1);
						lineRenderer.SetPosition (linenum + 1, temp2);
						linenum = linenum + 1;
					}	
					Vector3 temp = new Vector3 (hit.point.x, hit.point.y, hit.point.z);
					path.Add (temp);
					Debug.Log ("original" + temp.x + " " + temp.y + " " + temp.z);
				}
				if (u == 1) {
//					
					Vector3 temp  = new Vector3(hit.point.x,hit.point.y,hit.point.z);
					enemy.Add (temp);
					GameObject obj = Instantiate (sphere, new Vector3 (hit.point.x, hit.point.y+10, hit.point.z), Quaternion.Euler(new Vector3(90,0,0))) as GameObject;
					Debug.Log ("enemyfiredraw" + temp.x + " " + temp.y + " " + temp.z);
				}
				if (w == 1) {
					//		
					Debug.Log("camehere");
					Vector3 temp  = new Vector3(hit.point.x,hit.point.y,hit.point.z);

					if (popup.don == 1) {
						GameObject objec = Instantiate (StartMarker, popup.d, Quaternion.Euler (new Vector3 (90, 0, 0))) as GameObject;
					}
					path.Add (temp);
					GameObject obj = Instantiate (StartMarker, new Vector3 (hit.point.x, hit.point.y+5, hit.point.z), Quaternion.Euler(new Vector3(90, 0, 0))) as GameObject;					Debug.Log ("redrwed" + temp.x + " " + temp.y + " " + temp.z);

				}
	

			}

			if (Input.GetMouseButtonDown (2)) {
				u = 1;
				loadscene1 ();

			
			}
			if (Input.GetMouseButtonDown (1)) {
				 
				if ((u == 1) && (w == 0)) {
					u = 2;
					loadscene2 ();
				}
				if ((u == 2) && (w == 1)) {
					//Debug.Log ("reached also");
					//w = 0;
					//Application.LoadLevel (7);
					//loadscene2 ();
				}
				if (w == 1) {
					PlayerPrefs.SetInt (A, 1);
					Application.LoadLevel (7);

				}
			}
				


		}

		//tw.Close();


	}
	public void loadscene0(){

		Application.LoadLevel (0);
		//Debug.Log(path.Count);

	} 

	public void loadscene1(){


		Application.LoadLevel (1);
		//Debug.Log(path.Count);

	}

	public void loadscene2(){

		//Debug.Log (enemy.Count);
		enemycount=enemy.Count;
		PlayerPrefs.SetInt ("enemycount", enemycount);
		move = true;
		tank_movement.i = 0;
		Debug.Log (path.Count);
		Debug.Log ("loadedscene2");
		sphere.transform.position = path [0];
		Application.LoadLevel (2);
		//Debug.Log(path.Count);

	}

}