using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFactoryClick : MonoBehaviour {
    public GameObject Maincamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
    //    Debug.Log("fff");
       Maincamera.GetComponent< ClickMousebutton>().ActiveInfoBox++;
    }
}
