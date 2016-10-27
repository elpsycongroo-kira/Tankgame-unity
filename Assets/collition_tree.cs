using UnityEngine;
using System.Collections;

public class collition_tree : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("Collision");
		Debug.Log (col.gameObject.name);
		Debug.Log (col.gameObject.tag);
		//Destroy (this.gameObject);
		if(col.gameObject.tag == "Tree")
		{
			Debug.Log ("collisiion with tree3");
			Destroy(col.gameObject);
		}
		if (col.gameObject.name == "tree_high_b") {
			Debug.Log ("works");
		}
		//if(col.gameObject.name == "Cube")
	//	{
		//	Debug.Log ("collisiion with tree2");
		//	Destroy(col.gameObject);
	//	}


		/*if(col.gameObject.tag == "Tree")
		{
			Debug.Log ("collisiion with tree1");
			Destroy(col.gameObject);
		}*/
	}
}
