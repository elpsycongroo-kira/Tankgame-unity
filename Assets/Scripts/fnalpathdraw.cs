using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class fnalpathdraw : MonoBehaviour {
	int linenum=0;
	Vector3 ip,fp;
	int k=0;
	public  List<Vector3> ffpath = new List<Vector3>();
	public int o=0;
	// Use this for initialization

	void Start () {
		LineRenderer lineRenderer = GetComponent<LineRenderer> ();
		Debug.Log (tank_movement.fpath.Count);
		Debug.Log (tank_movement.fpath [0]);
		ffpath = tank_movement.fpath;
		//o = collision.countforcol;
//		Debug.Log("count=="+Collision.countforcol);
	}
	
	// Update is called once per frame
	void Update () {

		if(linenum<=(tank_movement.fpath.Count-2)){

			LineRenderer lineRenderer = GetComponent<LineRenderer> ();
		
		lineRenderer.SetVertexCount(linenum + 2);
			Vector3 temp1=tank_movement.fpath [linenum] ;
			Vector3 temp2=tank_movement.fpath [linenum+1];
			temp1.y += 10;
			temp2.y += 10;
			lineRenderer.SetPosition (linenum, tank_movement.fpath[linenum]);
			lineRenderer.SetPosition (linenum + 1, tank_movement.fpath[linenum+1]);
			linenum = linenum + 1;
		}
		
			
	/*	if (k < tank_movement.fpath.Count) {
					ip = tank_movement.fpath [k];
					fp = tank_movement.fpath [k + 1];
						transform.position = Vector3.MoveTowards (transform.position, fp, Time.deltaTime * 1000000);

				}	*/

			
}
}