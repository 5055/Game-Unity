using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMousebutton : MonoBehaviour {
    public GameObject Ingoblock;
    public int ActiveInfoBox = 0;
    public bool tActiveInfoBox;
    bool inline = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            Invoke("LaunchProjectile", 1);

        }
    }

    void LaunchProjectile()
    {
        //          Debug.Log("ttt");
        Debug.Log(ActiveInfoBox);
        if (ActiveInfoBox<1)
        {
            //         Debug.Log("nnn");
     //       Ingoblock.SetActive(false);
        }
        if (ActiveInfoBox > 0)
        {
          //  Debug.Log("www");
         //   Ingoblock.SetActive(true);
            ActiveInfoBox --;
        }
        inline = false;

    }

    void OnMouseDown()
    {
      //  Debug.Log("fff");
     //   Ingoblock.GetComponent<TurnFactoryINfo>().ActiveInfoBox;
    }
}
