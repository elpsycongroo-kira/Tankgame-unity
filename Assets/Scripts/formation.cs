using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class formation : MonoBehaviour {
	public GameObject Tshape;
	public GameObject InverseTshape;
	public Sprite tickmark;
	public Sprite empty;
	Image tshape;
	Image invtshape;
	string T="tshape";
	//public int a=0;
	//string invT="invtshape";

	public void selectT()
	{
		tshape = Tshape.GetComponent<Image> ();
		invtshape = InverseTshape.GetComponent<Image>();
		if (tshape.sprite == empty && invtshape.sprite == empty) {
			tshape.sprite = tickmark;
			PlayerPrefs.SetInt (T, 1);
			PlayerPrefs.SetString ("initialformation", "T-Shape");
		} else if (tshape.sprite == empty && invtshape.sprite == tickmark) {
			tshape.sprite = tickmark;
			invtshape.sprite = empty;
			PlayerPrefs.SetInt (T, 1);
			PlayerPrefs.SetString ("initialformation", "T-Shape");
		} else if (tshape.sprite == tickmark && invtshape.sprite == empty) {
			tshape.sprite = empty;
			PlayerPrefs.SetInt (T, -1);
		}
	}

	public void selectInvT()
	{
		tshape = Tshape.GetComponent<Image> ();
		invtshape = InverseTshape.GetComponent<Image> ();
		if (tshape.sprite == empty && invtshape.sprite == empty) {
			invtshape.sprite = tickmark;
			PlayerPrefs.SetInt (T, 0);
			PlayerPrefs.SetString ("initialformation", "InvT-Shape");
		} else if (tshape.sprite == tickmark && invtshape.sprite == empty) {
			tshape.sprite = empty;
			invtshape.sprite = tickmark;
			PlayerPrefs.SetInt (T, 0);
			PlayerPrefs.SetString ("initialformation", "InvT-Shape");
		} else if (tshape.sprite == empty && invtshape.sprite == tickmark) {
			invtshape.sprite = empty;
			PlayerPrefs.SetInt (T, -1);
		}
	}
}

