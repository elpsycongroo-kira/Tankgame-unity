using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {

	public Rigidbody shell;
	public Rigidbody turret;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space")){
			Rigidbody shellInstance =	Instantiate(shell,turret.position,turret.rotation) as Rigidbody;
			shellInstance.AddForce(30, 10, 50);
			Debug.Log (shellInstance.velocity);
		}
	}
}
