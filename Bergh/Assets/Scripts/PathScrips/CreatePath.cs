using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePath : MonoBehaviour {
    public GameObject Pathcollection;
    public GameObject Ground;
    public Rigidbody Cube;
    public bool PathOn = false;
    Collider clonec, Groundc;
    bool ButtonPressed= false;
    private Vector3 mousepos;
    public int Pathnum=0;
    public GameObject Groundchild;

    void Start() {

    }


    void Update()
    {
        if (PathOn)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ButtonPressed = true;
            }
            if (Input.GetMouseButtonUp(0))
            {
                ButtonPressed = false;
            }
            if (ButtonPressed)
            {

                mousepos = Input.mousePosition; // ik ben een banaan
                mousepos.z = 0;
                mousepos = Camera.main.ScreenToWorldPoint(mousepos);

                var clone = Instantiate(Cube, new Vector3(mousepos.x, mousepos.y, 99), Quaternion.identity);
                clone.name = "Path" + Pathnum;
                clone.transform.gameObject.SetActive(true);
                // clone.transform.position
                clone.transform.parent = Pathcollection.transform;


            }

        }
    }

    public void Path(){
        if (!PathOn) {
            PathOn = true;

        }
        else if (PathOn)
        {
            PathOn = false;

        }

    }
}
