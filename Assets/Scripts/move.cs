using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public Rigidbody tank;
	public Rigidbody rr;
	public float speed;
	public float tempt;
    public float flgg = 1;
	public float F2=1;
	public Vector3 speed1;
	public Vector3 A;
	public Vector3 direction;
	public Vector3 cp;
	public Vector3 maxvelocity;
	public Vector3 Intialpoint;
	public Vector3 Finalpoint;
	public float flag=0;
	public float distance;
	public float a;//acceleration
	//public float ax;
	public float Tt;//totaltime
	public float ct=0;//currenttime
	// Use this for initialization
	int i;
	Ray ray;
	RaycastHit hit;
	void Start () {
		
		//A=Finalpoint-Intialpoint;
		tank.transform.position = instanciateobjectonclick.path[0];
		//A = instanciateobjectonclick.path [1] - instanciateobjectonclick.path [0];

			
        transform.rotation = Quaternion.LookRotation(-1*A);

        /*distance = A.magnitude;
		direction = A / distance;
		direction.y = 0;
		Tt = (distance/speed);
		a = (4 * speed) / (Tt);
		maxvelocity = a * (Tt / 2)*direction;
		//ax = dir.x * a;*/


		tank = GetComponent<Rigidbody>();
	}
	public void Stopper(){
		tank.AddForce (direction * 0);
		flag = 1;
        flgg = 0;
		tank.velocity = Vector3.zero;
		tank.angularVelocity = Vector3.zero;
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Terrain") {
			//tank.AddForce (0, 0, 0);

		}
		Debug.Log (col.gameObject.name);

	}
    void FixedUpdate()
    {
		/*Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, 10)) {
			rr.transform.position= new Vector3(hit.x,hit.y,hit.z);		
		}*/
		//tank.AddForce (0,-10000, 0);

		if (Mathf.Abs (Vector3.Distance (transform.position,instanciateobjectonclick.path [i + 1] )) > 0.1f) {
			if (i < instanciateobjectonclick.path.Count) {
				Vector3 newpos = transform.position; 
				newpos.y = Terrain.activeTerrain.SampleHeight (transform.position);
				tank.transform.position = newpos;
				tank.transform.position = Vector3.MoveTowards (tank.transform.position, instanciateobjectonclick.path [i + 1], Time.deltaTime * speed);


			} else
				i++;
		}



    /*    if (flgg == 1)
        {
            if (ct <= Tt)
            {

                if ((ct <= Tt / 2) || (((ct > Tt / 2) && ((ct < (Tt / 2) + .02))) && (F2 == 1)))
                {

                    if (((ct > Tt / 2) && ((ct < (Tt / 2) + .02))) && (F2 == 1))
                    {
                        ct = Tt / 2;
                        F2 = 0;
                        tank.velocity = maxvelocity;

                    }
                    if (F2 == 1)
                    {
                        //tank.AddForce (direction * a);
                        tank.velocity = (a * ct * direction);
                        speed1 = tank.velocity;
                    }
                }
                if (ct > Tt / 2)
                {
                    //tank.AddForce (direction * (-1 * a));
                    tank.velocity = (maxvelocity) - (a * (ct - (Tt / 2)) * direction);
                    speed1 = tank.velocity;
                }
                ct = ct + Time.deltaTime;
            }

            if ((ct > Tt) && ((ct < (Tt) + .02)))
            {
                tempt = ct - Tt;
                tank.velocity = direction * 0;
                flag = 1;
                speed1 = tank.velocity;


            }
            cp = tank.transform.position;

        }*/
    }
}