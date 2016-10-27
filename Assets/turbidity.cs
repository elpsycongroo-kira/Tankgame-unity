using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class turbidity : MonoBehaviour {

	//public int[] turbid = new int[21];
	private int turbid;

	public Text Warning;


	// Use this for initialization
	void Start () {
		turbid = Random.Range (0, 21);

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (turbid);
		//GetComponent<GUIText>().text = turbid.ToString ();
		Warning.text ="Turbidity = " + turbid.ToString();
	}
}
