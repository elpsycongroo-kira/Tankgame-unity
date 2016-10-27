using UnityEngine;
using System.Collections;

public class fff: MonoBehaviour {
	public Rigidbody Bullet;
	public float delay;
	public Transform barrelEnd;
	public float speed;
	public GameObject DamagedTank;
	public GameObject FireBullet;
	void Start()
	{
		//InvokeRepeating("Spawn", delay, delay);	
	}

	void Update() {
	if(Input.GetButtonDown("Jump"))
		{
		Rigidbody bullet;
			GameObject fireBullet;
			fireBullet = Instantiate (FireBullet, barrelEnd.position, barrelEnd.rotation) as GameObject;

		bullet = Instantiate(Bullet, barrelEnd.position , barrelEnd.rotation) as Rigidbody;
			AudioSource shootSound = GetComponent<AudioSource> () as AudioSource;
			shootSound.Play ();
		//bullet.velocity = transform.TransformDirection(new Vector3(10f,10f,10f)) * speed;
			bullet.AddForce(barrelEnd.forward * (1*speed));
			Destroy(bullet.gameObject, 3);
			Destroy (fireBullet, 1f);

		}
			
	}





}
