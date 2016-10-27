using UnityEngine;
using System.Collections;

public class FormationTabController : MonoBehaviour {

	public GameObject FormationTab;
	void Start () {
		if (PlayerPrefs.GetString ("Role") == "Commander") {
			FormationTab.SetActive (true);
		} else {
			FormationTab.SetActive(false);
		}
	}
	

}
