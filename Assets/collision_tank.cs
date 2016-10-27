using UnityEngine;
using System.Collections;

public class collision_tank : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void onTriggerEnter(Collider col){
		if(col.tag=="mkill"){
			Debug.Log("mkill");
		}
		if(col.tag=="kkill")
			Debug.Log("kkill");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
