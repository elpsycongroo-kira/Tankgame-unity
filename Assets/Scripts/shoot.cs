using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour
{
	//public Rigidbody bullet_tank;
	//public Transform barrelEnd;
  //  public float speed=2000;
  ////  public GameObject smoke;
  //  private AudioSource fireAudio;
   // public GameObject DamagedTank;
   // bool flag = false;
   

    void OnTriggerEnter(Collider col)
    {
		if(col.tag=="enemy"){
			//Destroyenemy;
			//destroyblletalso
		}
        

		if(col.tag=="mkill"){
				Debug.Log("mkill");
		}
		if(col.tag=="kkill")
			Debug.Log("kkill");

    }
     
}