using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class arjunSelection : MonoBehaviour {

	Image selection;
	public Sprite tickmark;
	public Sprite empty;
	public GameObject T90;
	Image t90sprite;
	public void arSelection()
	{
		selection = GetComponent<Image>();
		t90sprite = T90.GetComponent<Image> ();
		if (selection.sprite == tickmark && t90sprite.sprite == empty) {
			selection.sprite = empty;
		} else if (selection.sprite == empty && t90sprite.sprite == empty) {
			selection.sprite = tickmark;
		} else if (selection.sprite == empty && t90sprite.sprite == tickmark) {
			selection.sprite = tickmark;
			t90sprite.sprite = empty;
		}
	}
}
