using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveHouse : MonoBehaviour {
    public ContainVariable Variable;
    GameObject MainCamera;
    // Use this for initialization
    void Start () {
		
	}

    public void OnMouseDown()
    {
        if (Variable.DestroyMode)
        {
            Variable.Workers -= 4;
            Destroy(this.gameObject);

        }
    }
}
