using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHarbor : MonoBehaviour {
    public GameObject map;
    public int x, y, z;
    // Use this for initialization
    void Start() {

    }
    public void Setdown() { 
        
        Collider collider1 = this.gameObject.GetComponent<Collider>();
        Collider collider2 = map.GetComponent<Collider>();
        if (collider1.bounds.Intersects(collider2.bounds))
        {
            this.gameObject.transform.parent.transform.Rotate(x, y, z, Space.Self);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
