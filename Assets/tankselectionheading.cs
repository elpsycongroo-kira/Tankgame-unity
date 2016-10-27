using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tankselectionheading : MonoBehaviour {
	Image t90;
	Image arjun;
	Image t901;
	Image arjun1;
	Image t902;
	Image arjun2;
	public Sprite tickmark;
	public Sprite empty;
	public GameObject commanderT90;
	public GameObject troop1T90;
	public GameObject troop2T90;
	public GameObject commanderarj;
	public GameObject troop1arj;
	public GameObject troop2arj;

	string T="commander";
	string t1="troop1";
	string t2="troop2";

	public void commanderselect90()
	{
		t90 = commanderT90.GetComponent<Image> ();
		arjun = commanderarj.GetComponent<Image>();
		if (t90.sprite == empty && arjun.sprite == empty) {
			t90.sprite = tickmark;
			PlayerPrefs.SetInt (T, 1);
		} else if (t90.sprite == empty && arjun.sprite == tickmark) {
			t90.sprite = tickmark;
			arjun.sprite = empty;
			PlayerPrefs.SetInt (T, 1);
		} else if (t90.sprite == tickmark && arjun.sprite == empty) {
			t90.sprite = empty;
			PlayerPrefs.SetInt (T, -1);
		}
	}
	public void commanderselectarj()
	{
		t90 = commanderT90.GetComponent<Image> ();
		arjun = commanderarj.GetComponent<Image>();
		if (t90.sprite == empty && arjun.sprite == empty) {
			arjun.sprite = tickmark;
			PlayerPrefs.SetInt (T, 0);
		} else if (t90.sprite == empty && arjun.sprite == tickmark) {
			//arjun.sprite = tickmark;
			arjun.sprite = empty;
			PlayerPrefs.SetInt (T, 0);
		} else if (t90.sprite == tickmark && arjun.sprite == empty) {
			t90.sprite = empty;
			arjun.sprite = tickmark;
			PlayerPrefs.SetInt (T, -1);
		}
	}
	public void troop1select90()
	{
		t901 = troop1T90.GetComponent<Image> ();
		arjun1 = troop1arj.GetComponent<Image>();
		if (t901.sprite == empty && arjun.sprite == empty) {
			t901.sprite = tickmark;
			PlayerPrefs.SetInt (t1, 1);
		} else if (t90.sprite == empty && arjun.sprite == tickmark) {
			t901.sprite = tickmark;
			arjun1.sprite = empty;
			PlayerPrefs.SetInt (t1, 1);
		} else if (t90.sprite == tickmark && arjun.sprite == empty) {
			t901.sprite = empty;
			PlayerPrefs.SetInt (t1, -1);
		}
	}
	public void troop1selectarj()
	{
		t901 = troop1T90.GetComponent<Image> ();
		arjun1 = troop1arj.GetComponent<Image>();
		if (t901.sprite == empty && arjun1.sprite == empty) {
			arjun1.sprite = tickmark;
			PlayerPrefs.SetInt (t1, 0);
		} else if (t901.sprite == empty && arjun1.sprite == tickmark) {
			//arjun.sprite = tickmark;
			arjun1.sprite = empty;
			PlayerPrefs.SetInt (t1, 0);
		} else if (t901.sprite == tickmark && arjun1.sprite == empty) {
			t901.sprite = empty;
			arjun1.sprite = tickmark;
			PlayerPrefs.SetInt (t1, -1);
		}
	}
	public void troop2select90()
	{
		t902 = troop2T90.GetComponent<Image> ();
		arjun2 = troop2arj.GetComponent<Image>();
		if (t902.sprite == empty && arjun2.sprite == empty) {
			t902.sprite = tickmark;
			PlayerPrefs.SetInt (t2, 1);
		} else if (t902.sprite == empty && arjun2.sprite == tickmark) {
			t902.sprite = tickmark;
			arjun2.sprite = empty;
			PlayerPrefs.SetInt (t2, 1);
		} else if (t902.sprite == tickmark && arjun2.sprite == empty) {
			t902.sprite = empty;
			PlayerPrefs.SetInt (t2, -1);
		}
	}
	public void troop2selectarj()
	{
		t902= troop2T90.GetComponent<Image> ();
		arjun2 = troop2arj.GetComponent<Image>();
		if (t902.sprite == empty && arjun2.sprite == empty) {
			arjun2.sprite = tickmark;
			PlayerPrefs.SetInt (t2, 0);
		} else if (t902.sprite == empty && arjun2.sprite == tickmark) {
			//arjun.sprite = tickmark;
			arjun2.sprite = empty;
			PlayerPrefs.SetInt (t2, 0);
		} else if (t902.sprite == tickmark && arjun2.sprite == empty) {
			t902.sprite = empty;
			arjun2.sprite = tickmark;
			PlayerPrefs.SetInt (t2, -1);
		}
	}





}
