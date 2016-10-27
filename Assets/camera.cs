using UnityEngine;
using System.Collections;
public class camera : MonoBehaviour {
	public Rigidbody tank;
	public float count = 1;
	public float smooth=1.5f;
	private int a=0;
	private int l=-5;
	Vector3 side1= new Vector3(-24.3f,5.5f,7.6f);
	Vector3 side2=new Vector3(-0.8f,6.1f,-15f);
	Vector3 side3= new Vector3(24.3f,5.5f,7.6f);
	Vector3 side4=new Vector3(-0.8f,6.1f,27.42f);
	//private Vector3  
	// Use this for initialization
	void Start () {
		


	
	
	}
	

	
	// Update is called once per frame
	void Update () {


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


		Debug.Log ("camera position " + transform.localPosition);
		if (Input.GetKeyDown ("c")) {
			a++;
			l = a % 4;
		}

		if (l == 1) {
			transform.localPosition = side1;
			
			var rotation = transform.localRotation * Quaternion.Euler (0, -90, 0);
	        
	        // Lerp the camera's rotation between it's current rotation and the rotation that looks at the player.
			transform.localRotation = rotation;
			l = -1;
		}

		if (l == 2) {
			transform.localPosition = side2;

			var rotation = transform.localRotation * Quaternion.Euler (0, -90, 0);

			// Lerp the camera's rotation between it's current rotation and the rotation that looks at the player.
			transform.localRotation = rotation;
			l = -1;
		}
		if (l == 3) {
			transform.localPosition = side3;

			var rotation = transform.localRotation * Quaternion.Euler (0, -90, 0);

			// Lerp the camera's rotation between it's current rotation and the rotation that looks at the player.
			transform.localRotation = rotation;
			l = -1;
		}
		if(l==0){
			transform.localPosition = side4;

			var rotation = transform.localRotation * Quaternion.Euler (0, -90, 0);

			// Lerp the camera's rotation between it's current rotation and the rotation that looks at the player.
			transform.localRotation = rotation;
			l = -1;
		}

		//Debug.Log("c="+a);
		//Debug.Log("l="+l);
	
	
	
	}

	}

