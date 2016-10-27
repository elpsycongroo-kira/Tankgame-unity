using UnityEngine;
using System.Collections;
public class rotation : MonoBehaviour {
	//private  Rigidbody rb;
	public float count = 1;
    public Vector3 r; 
   

	void Start() {
		//rb=GetComponent<Rigidbody>();
       // r = rb.transform.rotation;

	}
	void FixedUpdate () {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			count += 1;
			//rb.transform.rotation = Quaternion.Euler (0,count, 0);
            this.transform.rotation =  Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + count, this.transform.rotation.z); 
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			count += -1;
            //rb.transform.rotation = Quaternion.Euler(0, count, 0);
            this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y + count, this.transform.rotation.z); 
		}
	}
}