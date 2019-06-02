using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
    bool W, A, S, D;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            W = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            A = true;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            W = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            A = false;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            S = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            D = false;
        }

        if (W)
        {
            this.transform.position += new Vector3(0, 0.3F, 0);
        }
        if (A)
        {
            this.transform.position += new Vector3(-0.3F, 0, 0);
        }
        if (S)
        {
            this.transform.position += new Vector3(0, -0.3F, 0);
        }
        if (D)
        {
            this.transform.position += new Vector3(0.3F, 0, 0);
        }


    }
}
