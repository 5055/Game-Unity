using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteInfo : MonoBehaviour
{
   public GameObject RoutePrimaire, RouteSecondaire;
    Collider RoutePrimairec, RouteSecondairec,Routec;
    bool MovedonFactory = true;
    public bool Overlapbuildings = false;
    // Use this for initialization
    void Start()
    {
        if (Overlapbuildings) {
            InvokeRepeating("Overlapbuildingssendresource", 1.0f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!Overlapbuildings)
        {
            if (this != null)
            {
                Routec = this.gameObject.GetComponent<Collider>();
            }
            if (RoutePrimaire != null)
            {
                RoutePrimairec = RoutePrimaire.GetComponent<Collider>();
            }
            if (RouteSecondaire != null)
            {
                RouteSecondairec = RouteSecondaire.GetComponent<Collider>();
            }

            if (Routec.bounds.Intersects(RoutePrimairec.bounds))
            {
                if (MovedonFactory)
                {
                    MovedonFactory = false;
                    this.gameObject.GetComponent<Unit>().target = RouteSecondaire.transform;
                    this.gameObject.GetComponent<Unit>().RetryFindingRoute();
                }
            }
            else if (Routec.bounds.Intersects(RouteSecondairec.bounds))
            {
                if (MovedonFactory)
                {
                    RoutePrimaire.GetComponent<ProduceResource>().sentresourses();
                    MovedonFactory = false;
                    this.gameObject.GetComponent<Unit>().target = RoutePrimaire.transform;
                    this.gameObject.GetComponent<Unit>().RetryFindingRoute();
                }
            }
            else
            {
                MovedonFactory = true;
            }
        }
    }
    void Overlapbuildingssendresource()
    {
        RoutePrimaire.GetComponent<ProduceResource>().sentresourses();
    }

}
