using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveFactory : MonoBehaviour {
    public ContainVariable Variable;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnMouseDown()
    {
        if (Variable.DestroyMode)
        {
            for (int i = 0; i < this.GetComponent<ProduceResource>().RoutesList.Count; i++)
            {
                this.GetComponent<ProduceResource>().RoutesList[i].GetComponent<DestroyRoutes>().DestroythisRoute(this.gameObject);
            }
            Variable.Workers += 1;
            Destroy(this.gameObject);

        }
    }
}
