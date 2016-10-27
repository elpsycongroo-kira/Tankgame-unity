using UnityEngine;
using System.Collections;

public class changeCamera : MonoBehaviour {

    public GameObject camera1;
    public GameObject camera2;

    bool change = true;
    void Update()
    {
        if (Input.GetKeyDown("h")) {
            change = !change;
            camera1.SetActive(change);
            camera2.SetActive(!change);
        }
        
    }
}
