
using UnityEngine;
using System.Collections;

public class apopup : MonoBehaviour
{
	public GameObject tank;
	public static int decision = 0;
	tank_movement tm;
	public int c1 = 0;
	private Rect windowRect = new Rect(200, 200, 300, 150);
	private string messbox = "";
	//private string messageToSend = "";
	private string messageToSend1 = "";
	void Start () {
		tm = tank.GetComponent<tank_movement>();
		Debug.Log ("collison srupt");
	}
	private void OnGUI()
	{

		if (c1==1)
		{
			tm.stop = 1;
			windowRect = GUI.Window(1, windowRect, windowFunc, "!!Warning!!");
		}

	}
	private void windowFunc(int id)
	{

		GUILayout.Box(messbox, GUILayout.Height(90));

		GUILayout.BeginHorizontal();
		//messageToSend1 = (GUILayout.TextField(messageToSend1));
		if (GUILayout.Button("continue", GUILayout.Width(95)))
		{
			if (decision == 0) {
				tm.stop	= 0;
				SendMessage1 ("");
				c1 = 0;
			}
			if (decision == 1) {
				tm.stop	= 0;
				if (collision.threshold_turbidity >= collision.river_turbidity) {
					Application.LoadLevel (3);
				} else {
					Application.LoadLevel (3);
				}
				SendMessage1 ("");
				c1 = 0;
			}
		}
		if (GUILayout.Button ("Redraw", GUILayout.Width (95))) {
			//tm.stop = 0;
			tm.stop=0;
			instanciateobjectonclick.path.Clear();
			instanciateobjectonclick.path.Add (tank.transform.position);
			instanciateobjectonclick.w = 1;
			Application.LoadLevel (3);
			c1 = 0;
		}

		if (GUILayout.Button("Quit", 		GUILayout.Width(85)))
		{
			tm.stop = 0;
			SendMessage1("Quit" );
			c1 = 0;
		}
		GUILayout.EndHorizontal();
		GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
	}
	private void clearmsg()
	{
		GUILayout.TextField("");
	}
	public void SendMessage1(string mess)
	{

		if (mess != "")
		{
			messbox += mess + '\n';
		}
	}



}

