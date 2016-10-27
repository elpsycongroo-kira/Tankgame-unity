using UnityEngine;
using System.Collections;

public class ChooseRole : MonoBehaviour {
	
	public void showMapCommander(){
		PlayerPrefs.SetString("Role", "Commander");
		Application.LoadLevel (6);
	}
	public void showMaptroopMate(){
		//Debug.Log("Troopmate is role");
		PlayerPrefs.SetString ("Role", "Troopmate");
		Application.LoadLevel (6);
	}
}
