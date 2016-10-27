using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject bolt;
    public Transform Canon;
    public float fireRatep;
    public float fireRatem;
    private float nextFire = 3.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + Random.Range(fireRatep, fireRatem);
            Instantiate(bolt, Canon.position, Canon.rotation);
        }
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
