using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class t90Selection : MonoBehaviour {

	Image selection;
	public Sprite tickmark;
	public Sprite empty;
	public GameObject arjun;
	Image arjunsprite;
	public void T90Selection()
	{
		selection = GetComponent<Image>();
		arjunsprite = arjun.GetComponent<Image>();

		if (selection.sprite == tickmark && arjunsprite.sprite == empty) {
			selection.sprite = empty;
		} else if(selection.sprite == empty && arjunsprite.sprite == empty){
			selection.sprite = tickmark;
		} else if(selection.sprite == empty && arjunsprite.sprite== tickmark){
			selection.sprite = tickmark;
			arjunsprite.sprite = empty;
		}
	}
}
