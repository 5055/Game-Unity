using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPathConnection : MonoBehaviour
{
    Collider Pathc, thisPathc, Factorymapchildc;
    GameObject Path, Factorymapchild;
    public GameObject Pathcollection, Factorymap;

    public List<GameObject> Connections = new List<GameObject>();

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ChainStart()
    {
        bool change = false;

        if (Pathcollection != null)
        {
            thisPathc = this.GetComponent<Collider>();
        }

        {
            int children = Factorymap.transform.childCount;
            for (int i = 0; i < children; ++i)
            {
                Factorymapchild = Factorymap.gameObject.transform.GetChild(i).gameObject;
                if (Factorymap != null)
                {
                    Factorymapchildc = Factorymapchild.GetComponent<Collider>();
                }

                if (thisPathc.bounds.Intersects(Factorymapchildc.bounds) && this.name != Factorymapchild.name)
                {
                    if (!Connections.Contains(Factorymapchild))
                    {
                        Connections.Add(Factorymapchild);

                         change = true;
                    }
                }


            }




        }
        {
            int children = Pathcollection.transform.childCount;
            for (int i = 0; i < children; ++i)
            {
                Path = Pathcollection.gameObject.transform.GetChild(i).gameObject;
                if (Pathcollection != null)
                {
                    Pathc = Path.GetComponent<Collider>();
                }

                if (thisPathc.bounds.Intersects(Pathc.bounds) && this.name != Path.name)
                {
                    
                    foreach (GameObject j in Path.GetComponent<CheckPathConnection>().Connections)
                        if (!Connections.Contains(j))
                        {
                            Connections.Add(j);
                            change = true;
                        }
                }
            }
        }

        if (change)
        {
            {
                int children = Pathcollection.transform.childCount;
                for (int i = 0; i < children; ++i)
                {
                    Path = Pathcollection.gameObject.transform.GetChild(i).gameObject;
                    if (Pathcollection != null)
                    {
                        Pathc = Path.GetComponent<Collider>();
                    }

                    if (thisPathc.bounds.Intersects(Pathc.bounds) && this.name != Path.name)
                    {
                        //        Debug.Log(Factorymapchild.name);
                        //Debug.Log(Path.name);

                        Path.GetComponent<CheckPathConnection>().ChainChange(Connections);
                    }
                }
            }
            { 
            int children = Factorymap.transform.childCount;
                for (int i = 0; i < children; ++i)
                {
                    Factorymapchild = Factorymap.gameObject.transform.GetChild(i).gameObject;
                    if (Factorymap != null)
                    {
                        Factorymapchildc = Factorymapchild.GetComponent<Collider>();
                    }

                    if (thisPathc.bounds.Intersects(Factorymapchildc.bounds) && this.name != Factorymapchild.name)
                    {
                        foreach (GameObject j in Connections)
                        {
                            if (!Factorymapchild.GetComponent<FactoryInfo>().Connections.Contains(j))
                            {
                                Factorymapchild.GetComponent<FactoryInfo>().Connections.Add(j);
                            }
                        }
                    }

                }
            }

        }
    }
    public void ChainChange(List<GameObject> OtherConnections)
        {
            if (Pathcollection != null)
            {
                thisPathc = this.GetComponent<Collider>();
            }
            bool change = false;
            foreach (GameObject i in OtherConnections) { 
            if (!Connections.Contains(i)) {
                Connections.Add(i);
                change = true;
            }
        }
        if (change)
        {
            {
                int children = Pathcollection.transform.childCount;
                for (int i = 0; i < children; ++i)
                {
                    Path = Pathcollection.gameObject.transform.GetChild(i).gameObject;
                    if (Pathcollection != null)
                    {
                        Pathc = Path.GetComponent<Collider>();
                    }

                    if (thisPathc.bounds.Intersects(Pathc.bounds) && this.name != Path.name)
                    {
                        //        Debug.Log(Factorymapchild.name);
                        //Debug.Log(Path.name);
                        Path.GetComponent<CheckPathConnection>().ChainChange(Connections);
                    }
                }
            }
            {
                int children = Factorymap.transform.childCount;
                for (int i = 0; i < children; ++i)
                {
                    Factorymapchild = Factorymap.gameObject.transform.GetChild(i).gameObject;
                    if (Factorymap != null)
                    {
                        Factorymapchildc = Factorymapchild.GetComponent<Collider>();
                    }

                    if (thisPathc.bounds.Intersects(Factorymapchildc.bounds) && this.name != Factorymapchild.name)
                    {
                        foreach (GameObject j in Connections)
                        {
                            if (!Factorymapchild.GetComponent<FactoryInfo>().Connections.Contains(j))
                            {
                                Factorymapchild.GetComponent<FactoryInfo>().Connections.Add(j);
                            }
                        }
                    }

                }
            }

        }



    }
}
