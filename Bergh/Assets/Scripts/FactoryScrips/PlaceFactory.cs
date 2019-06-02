using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlaceFactory : MonoBehaviour
{
    public ContainVariable initiate;
    public bool specialground;
    public GameObject Ground;
    public Camera MainCamera;
    public GameObject Pathcollection,Factorymap, Groundmatc;
     bool House, Storage;
    Collider Pathc, thisPathc, Factoryc, Groundc,groundchild, Factorymapchildc;
    GameObject Path, Groundchild, Factorymapchild;
    private Vector3 v;
    private bool mousedown;
    private Vector3 mousepos;
    void Start()
    {
        House = this.gameObject.GetComponent<FactoryInfo>().House;
        Storage = this.gameObject.GetComponent<FactoryInfo>().Storage;
        {
                    {
            int children = Ground.transform.childCount;
                for (int i = 0; i < children; ++i)
                {
                    string GroundName = "";
                    int LetterCount = 9;
                    if (specialground)
                    {
          //             Debug.Log("ggggggggggggggggggggg");

                        while (LetterCount < Ground.transform.GetChild(i).name.Length)
                        {
                            //    Debug.Log(Ground.transform.GetChild(i).name[LetterCount]);
                            GroundName = GroundName + Ground.transform.GetChild(i).name[LetterCount];

                            LetterCount++;


                        }
                        // Debug.Log(GroundName);
                        //  Debug.Log(this.GetComponent<FactoryInfo>().FactoryName);
                        
                        if (GroundName == this.GetComponent<FactoryInfo>().FactoryName)
                        {
                            Groundchild = Ground.gameObject.transform.GetChild(i).gameObject;
                            if (Ground != null)
                                Groundc = Groundchild.GetComponent<Collider>();
                        }
                    }
                    else {
                        Groundc = Groundmatc.GetComponent<Collider>();

                    }
                }
                }
        }

            if (this != null)
                Factoryc = this.GetComponent<Collider>();


        mousedown = true;
        v = Input.mousePosition;
    }


    void Update()
    {
        if (mousedown == true)
        {
            mousepos = Input.mousePosition;
            mousepos.z = 0;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

         //   Vector3 diff = v - Input.mousePosition;
            this.transform.position = new Vector3(mousepos.x, mousepos.y, 99);

        }



        v = Input.mousePosition;

    }
    void OnMouseUp()
    {


        //    Debug.Log(Groundc.bounds);
        //     Debug.Log(Factoryc.bounds);
        if (House || Storage || (!House && !Storage && MainCamera.GetComponent<ContainVariable>().Workers>0))
        {

            if (Factoryc.bounds.Intersects(Groundc.bounds) && (!Factoryc.bounds.Intersects(Groundmatc.GetComponent<Collider>().bounds) || (Factoryc.name[0] != 52)))
            {
                    mousedown = false;
                    Vector3 diff = v - Input.mousePosition;
                    this.transform.position = new Vector3(Mathf.Round((this.transform.position.x) * 2) / 2, Mathf.Round(((this.transform.position.y)) * 2) / 2, 99);

                    {
                        int children = Factorymap.transform.childCount;
                        for (int i = 0; i < children; ++i)
                        {
                            Factorymapchild = Factorymap.gameObject.transform.GetChild(i).gameObject;
                            if (Factorymap != null)
                            {
                                Factorymapchildc = Factorymapchild.GetComponent<Collider>();
                            }

                            if (Factoryc.bounds.Intersects(Factorymapchildc.bounds) && this.name != Factorymapchild.name)
                            {
                            //        Debug.Log(Factorymapchild.name);
                            //        Debug.Log(this.name);
                                Destroy(this.gameObject);
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

                            if (Factoryc.bounds.Intersects(Pathc.bounds) && this.name != Path.name)
                            {
                                //        Debug.Log(Factorymapchild.name);
                                //Debug.Log(Path.name);
                                if (House)
                                {
                                    MainCamera.GetComponent<ContainVariable>().Workers -= 4;
                                }
                            Destroy(this.gameObject);
                            }

                        }
                    }

                    initiate.FactoryNum++;
                    this.transform.localScale += new Vector3(0.05F, 0.05F, 0);



                    {
                        int Pchildren = Pathcollection.transform.childCount;
                        for (int i = 0; i < Pchildren; ++i)
                        {
                            Path = Pathcollection.gameObject.transform.GetChild(i).gameObject;
                            if (Pathcollection != null)
                            {
                                Pathc = Path.GetComponent<Collider>();
                            }

                            if (Factoryc.bounds.Intersects(Pathc.bounds) && this.name != Path.name)
                            {
                                //Debug.Log(Path.name);
                                Path.GetComponent<CheckPathConnection>().ChainStart();
                            }
                        }
                    }





                bool blockplacement = false;

                    for (int i = 0; i < this.gameObject.GetComponent<BuildCost>().Buildcost.Length; ++i)
                    {
                        if (this.gameObject.GetComponent<BuildCost>().Buildcost[i] > MainCamera.GetComponent<ContainVariable>().GlobalResource[i])
                        {
                            Destroy(this.gameObject);
                        blockplacement = true;
                        }
                    }
                if (!blockplacement)
                {
                    if (!House)
                    {
                        MainCamera.GetComponent<ContainVariable>().Workers -= 1;
                    }
                    for (int i = 0; i < this.gameObject.GetComponent<BuildCost>().Buildcost.Length; ++i)
                    {

                        MainCamera.GetComponent<ContainVariable>().GlobalResource[i] -= this.gameObject.GetComponent<BuildCost>().Buildcost[i];
                    }
                    if (this.GetComponent<FactoryInfo>().Harbor)
                    {
                        for (int i = 1; i < 5; ++i)
                        {
                            //   Debug.Log(transform.GetChild(i).name);
                            this.gameObject.transform.GetChild(i).GetComponent<RotateHarbor>().Setdown();

                        }

                    }
                }
                Debug.Log("hhh");
                    Destroy(this);


            }
            else
            {
                if (House)
                {
                    MainCamera.GetComponent<ContainVariable>().Workers -= 4;
                }
      //          Debug.Log("hhh");
                Destroy(gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }





        
    }
}
