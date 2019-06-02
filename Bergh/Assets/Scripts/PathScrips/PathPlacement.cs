using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathPlacement : MonoBehaviour {
    public GameObject Pathcollection, Factorymap;
    public GameObject ButtonPath,Isle, PathFinding;
    bool Nofuctions= false;
    GameObject Path, Factorymapchild;
    Collider Pathc,thisPathc, Factorymapchildc, Groundc, gPathc;
    BoxCollider Isleb;

    // Use this for initialization
    void Start () {
        Isleb = Isle.GetComponent<BoxCollider>();
        Isleb.size = new Vector3(1F, 1F, 1F);

        if (Pathcollection != null)
        {
            thisPathc = this.GetComponent<Collider>();
        }

        Vector3 v = Input.mousePosition;

        Vector3 diff =v- Input.mousePosition;
        this.transform.position = new Vector3((Mathf.Round((this.transform.position.x+0.25F)*2) ) /2 -0.25F, (Mathf.Round(((this.transform.position.y + 0.25F )* 2) )) /2-0.25F, 99.5F);
        {
            {
                //     Groundchild = Ground.gameObject.transform.GetChild(i).gameObject;
                if (Isle != null)
                    Groundc = Isle.GetComponent<Collider>();
                

                if (Pathcollection != null)
                {
                    gPathc = this.GetComponent<Collider>();
                }


                if (!gPathc.bounds.Intersects(Groundc.bounds))
                {
                    Isleb.size = new Vector3(0.85F, 0.75F, 1F);
                    Destroy(this.gameObject);
                }
                Isleb.size = new Vector3(0.85F, 0.75F, 1F);
            }
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
                    Nofuctions = true;
                    Destroy(this.gameObject);
                }
                else
                {

                    //    Pathnum++;
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

                if (Pathc.bounds.Intersects(Factorymapchildc.bounds) && this.name != Factorymapchild.name)
                {
                    //        Debug.Log(Factorymapchild.name);
                    //        Debug.Log(this.name);
                    Nofuctions = true;
                    Destroy(this.gameObject);
                    
                }
            }


        }
        //    initiate.FactoryNum++;
        if (!Nofuctions)
        {
            ButtonPath.GetComponent<CreatePath>().Pathnum++;
            this.transform.localScale += new Vector3(0.1F, 0.1F, 0);

                this.GetComponent<CheckPathConnection>().ChainStart();
            PathFinding.GetComponent<Grid>().UpdateToGrid();




        }
        Destroy(this);



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
