using UnityEngine;
using System.Collections;

public class coll2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("tree is in collision");
		//Destroy (this.gameObject);
		/*if(col.gameObject.tag == "Tree")
		{
			Debug.Log ("collisiion with tree3");
			Destroy(col.gameObject);
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
