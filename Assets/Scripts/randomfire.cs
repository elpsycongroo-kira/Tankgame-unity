using UnityEngine;
using System.Collections;

public class randomfire: MonoBehaviour {
    public Rigidbody Bullet;
    public float delay=0.2f;
    public float speed=0.25f;
    public GameObject DamagedTank;
	private float nextfire = 4.99f;
	//public float nextfire2;
	private float nextfire1 = 0;


    void Start()
    {
        //InvokeRepeating("Spawn", delay, delay);
    }

    void FixedUpdate() {
		if (nextfire1 > nextfire) {
			Rigidbody bullet;

			bullet = Instantiate (Bullet, transform.position, transform.rotation) as Rigidbody;
			bullet.velocity = transform.TransformDirection (new Vector3 (10f, 10f, 10f)) * speed;
			Destroy (bullet,4);
		}
		nextfire1 = (nextfire1 + Time.deltaTime) % 5;
        //Destroy(bullet.gameObject, 3);
    }
	void OnCollisionEnter(Collision coll)
	{
		//Debug.Log ("hasdasd");
		if (coll.gameObject.name == "Test 2_x0_y0") {
			Destroy (Bullet.gameObject);
		}
		
		if (coll.gameObject.name == "T-90-chaitu") {
			Destroy (Bullet.gameObject);
		}
	
	}




}
