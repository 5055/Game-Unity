using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectFactory : MonoBehaviour {
    public GameObject Factorymap, Pathbutton;
    public GameObject FactoryInput, FactoryOutput;
    GameObject Factorymapchild;
    Collider Factorymapchildc;
    Ray ray;
    RaycastHit hit;
    bool mousepressed = true;
    bool connectbuttonpressed;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (connectbuttonpressed)
        {
            if (mousepressed)
            {
                if (Input.GetMouseButton(0))
                {
                    mousepressed = false;
                    ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    int children = Factorymap.transform.childCount;
                    for (int i = 0; i < children; ++i)
                    {
                        Factorymapchild = Factorymap.gameObject.transform.GetChild(i).gameObject;
                        if (Factorymap != null)
                        {
                            Factorymapchildc = Factorymapchild.GetComponent<Collider>();
                        }
                        if (Physics.Raycast(ray, out hit))
                        {
                            if (hit.collider.name == Factorymapchild.name)
                            {


                                //          Debug.Log(FactoryInput);

                                if (FactoryInput == null)
                                {

                                    FactoryInput = Factorymapchild;

                                }
                                else if (FactoryInput != null && FactoryOutput == null)
                                {

                                    FactoryOutput = Factorymapchild;
                                    if (FactoryInput != FactoryOutput && FactoryInput.GetComponent<FactoryInfo>().House == false && FactoryOutput.GetComponent<FactoryInfo>().House == false) { 
                                        FactoryInput.GetComponent<ProduceResource>().SendDataInput(FactoryOutput);
                                    FactoryOutput.GetComponent<ProduceResource>().SendDataOutput(FactoryInput);
                                }
                                        FactoryInput = null;
                                        FactoryOutput = null;
                                        connectbuttonpressed = false;
                                    }
                                    else
                                    {
                                        connectbuttonpressed = false;
                                    }

                        }
                        }


                    }
                }
            }
            if (!Input.GetMouseButton(0))
            {
                //      Debug.Log("mousepressed");
                mousepressed = true;
            }
        }
    
}



public void ActivateConnectionMode()
{
        Pathbutton.GetComponent<CreatePath>().PathOn = false;
        connectbuttonpressed = true;

}



}
