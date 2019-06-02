using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePath : MonoBehaviour {
    public ContainVariable Variable;
    public GameObject PathFinding;
    bool Mousedown = false;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            Mousedown = true;
    }
            if (Input.GetMouseButtonUp(0)){
            Mousedown = false;
    }

    }

    public void OnMouseOver()
    {
        if (Variable != null)
        {
            if (Variable.DestroyMode)
            {
                if (Mousedown)
                {

                    PathFinding.GetComponent<Grid>().UpdateToGrid();
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
