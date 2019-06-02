using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRoutes : MonoBehaviour {
    public GameObject MainCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void DestroythisRoute(GameObject DestroyedFactory)
    {
        if (this.GetComponent<RouteInfo>().RoutePrimaire != DestroyedFactory)
        {
            for (int i = 0; i < this.GetComponent<RouteInfo>().RoutePrimaire.GetComponent<ProduceResource>().RoutesList.Count; i++)
            {
                if (this.GetComponent<RouteInfo>().RoutePrimaire.GetComponent<ProduceResource>().RoutesList[i] == this.gameObject)
                {
                    this.GetComponent<RouteInfo>().RoutePrimaire.GetComponent<ProduceResource>().RoutesList.RemoveAt(i);
                }
            }
        }
        if (this.GetComponent<RouteInfo>().RouteSecondaire != DestroyedFactory)
        {
            for (int i = 0; i < this.GetComponent<RouteInfo>().RouteSecondaire.GetComponent<ProduceResource>().RoutesList.Count; i++)
            {
                if (this.GetComponent<RouteInfo>().RouteSecondaire.GetComponent<ProduceResource>().RoutesList[i] == this.gameObject)
                {
                    this.GetComponent<RouteInfo>().RouteSecondaire.GetComponent<ProduceResource>().RoutesList.RemoveAt(i);
                }
            }
        }
        MainCamera.GetComponent<ContainVariable>().Workers += 1;
        Destroy(this.gameObject);
    }
}
