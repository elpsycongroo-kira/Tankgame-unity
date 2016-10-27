using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tankcheck : MonoBehaviour {

	public GameObject T90;
	public GameObject Arjun;
	public GameObject Tshape;
	public GameObject InverseTshape;
	public GameObject textNotification;
	public GameObject textNotification2;
	public Sprite tickmark;
	public string scenetoLoad;

	bool tank = false;
	bool shape = false;
	float time = 2f;
	Image t90;
	Image arjun;
	Image tshape;
	Image invtshape;
	public void checkParameters()
	{	
		if (PlayerPrefs.GetInt ("asshole") == 1) {
			PlayerPrefs.SetInt ("asshole",-1);
			Application.LoadLevel (2);
		}
			else
			Application.LoadLevel(0);
		/*t90 = T90.GetComponent<Image> ();
		arjun = Arjun.GetComponent<Image> ();
		if (t90.sprite == tickmark || arjun.sprite == tickmark) {
			if(t90.sprite == tickmark)
			{
				PlayerPrefs.SetString("Tank", "T90");
			}
			else{
				PlayerPrefs.SetString("Tank", "Arjun");
			}
			tank = true;
		}
		if (PlayerPrefs.GetString ("Role") == "Commander") {
			tshape = Tshape.GetComponent<Image> ();
			invtshape = InverseTshape.GetComponent<Image> ();
			if (tshape.sprite == tickmark || invtshape.sprite == tickmark) {
				if(tshape.sprite == tickmark){
					PlayerPrefs.SetString("Formation", "Tshape");
				}
				else{
					PlayerPrefs.SetString("Formation","InvTshape");
				}
				shape = true;
			}
			if (tank == true && shape == true) {
				Application.LoadLevel (0);
			} else if (tank == false || shape == false) {
				textNotification.SetActive (true);
				StartCoroutine (Stop (time));
			}
		} else {
			if(tank == true){
				Application.LoadLevel(scenetoLoad);
			}
			else if(tank == false){
				textNotification2.SetActive (true);
				StartCoroutine (Stop2 (time));
			}
		}*/
	}

	IEnumerator Stop (float time)
	{
		yield return new WaitForSeconds (time);
		textNotification.SetActive(false);
	}
	IEnumerator Stop2 (float time)
	{
		yield return new WaitForSeconds (time);
		textNotification2.SetActive(false);
	}
}

