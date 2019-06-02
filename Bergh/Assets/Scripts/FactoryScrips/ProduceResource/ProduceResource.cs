using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceResource : MonoBehaviour
{
    //   public ContainVariable Produce;
    public GameObject RouteA, RouteCollection, MainCamera;
    public GameObject[] Inputsources;
    public GameObject[] Outputsources;
    public GameObject[] Routes;
    public int Produce = 0;
    public int[] Resource;
    public int[] inputRecource;
    public string inputRecource1;
    public string inputRecource2;
    public string inputRecource3;
    public string inputRecource4;
    public string inputRecource5;
    public string inputRecource6;
    public string inputRecource7;
    public bool Produces;
    public List<GameObject> RoutesList = new List<GameObject>();
    int level;


    void Start()
    {
        level = this.GetComponent<FactoryInfo>().level;
        Resource = new int[9];
        inputRecource = new int[9];
        for (int i = 0; i < Resource.Length; ++i)                                     // Input resources 
            {
                Resource[i] = 0;
            inputRecource[i] = -999;

            }
   //    if (Produces)
        {
            if (this.GetComponent<FactoryInfo>().FactoryName == "0")
            {

            }
            if (this.GetComponent<FactoryInfo>().FactoryName == "1")
            {

            }
            if (this.GetComponent<FactoryInfo>().FactoryName == "2")
            {
                inputRecource[0] = 0;
                inputRecource[1] = 1;
                inputRecource[2] = 2;
                inputRecource[3] = 3;
                inputRecource[4] = 4;
                inputRecource[5] = 5;
                inputRecource[6] = 6;
                inputRecource1 = "0";
                inputRecource2 = "1";
                inputRecource3 = "2";
                inputRecource4 = "3";
                inputRecource5 = "4";
                inputRecource6 = "5";
                inputRecource7 = "6";

            }
            if (this.GetComponent<FactoryInfo>().FactoryName == "3")
            {
                inputRecource[0] = 0;
                inputRecource[1] = 1;
                inputRecource[2] = 2;
                inputRecource[3] = 3;
                inputRecource[4] = 4;
                inputRecource[5] = 5;
                inputRecource[6] = 6;
                inputRecource1 = "0";
                inputRecource2 = "1";
                inputRecource3 = "2";
                inputRecource4 = "3";
                inputRecource5 = "4";
                inputRecource6 = "5";
                inputRecource7 = "6";

            }
            if ((this.GetComponent<FactoryInfo>().FactoryName == "3"|| this.GetComponent<FactoryInfo>().FactoryName == "4") && this.GetComponent<FactoryInfo>().Storage)
            {
                inputRecource[0] = 0;
                inputRecource[1] = 1;
                inputRecource[2] = 2;
                inputRecource[3] = 3;
                inputRecource[4] = 4;
                inputRecource[5] = 5;
                inputRecource[6] = 6;
                inputRecource1 = "0";
                inputRecource2 = "1";
                inputRecource3 = "2";
                inputRecource4 = "3";
                inputRecource5 = "4";
                inputRecource6 = "5";
                inputRecource7 = "6";


            }
            InvokeRepeating("OutputTime", 1f, 1f);
        }
    }
    void OutputTime()
    {
       if (Produces)
        {
            string FI = this.GetComponent<FactoryInfo>().FactoryName;                                           // Factory job
            if (FI == "0")
            {
                   Resource[0] += this.GetComponent<FactoryInfo>().level;
                Produce = Resource[0];
            }
            if (FI == "1")
            {
                Resource[1] += this.GetComponent<FactoryInfo>().level;
                Produce = Resource[1];
            }
            if (FI == "2")
            {
                if (Resource[0]*5 >= level && Resource[1]*5 >= level)
                {
                    Resource[2] += level;
                    Resource[0] -= level*5;
                    Resource[1] -= level*5;
                    Produce = Resource[2];
                }
            }
            if (FI == "3")
            {
                if (Resource[0]*5 >= level && Resource[2]*5 >= level)
                {
                    Resource[3] += level;
                    Resource[0] -= level*5;
                    Resource[2] -= level*5;
                    Produce = Resource[3];
                }
                if (FI == "4")
                {
                    if (Resource[1] * 5 >= level && Resource[3] * 5 >= level)
                    {
                        Resource[4] += level;
                        Resource[1] -= level * 5;
                        Resource[3] -= level * 5;
                        Produce = Resource[4];
                    }
                }
                if (FI == "5")
                {
                    if (Resource[3] * 5 >= level && Resource[4] * 5 >= level)
                    {
                        Resource[5] += level;
                        Resource[4] -= level * 5;
                        Resource[3] -= level * 5;
                        Produce = Resource[5];
                    }
                }
                if (FI == "6")
                {
                    if (Resource[6] * 5 >= level && Resource[0] * 5 >= level)
                    {
                        Resource[6] += level;
                        Resource[5] -= level * 5;
                        Resource[0] -= level * 5;
                        Produce = Resource[6];
                    }
                }
                if (FI == "7")
                {
                    if (Resource[6] * 5 >= level && Resource[3] * 5 >= level)
                    {
                        Resource[7] += level;
                        Resource[6] -= level * 5;
                        Resource[3] -= level * 5;
                        Produce = Resource[7];
                    }
                }
                if (FI == "8")
                {
                    if (Resource[0] * 5 >= level && Resource[1] * 5 >= level && Resource[2] * 5 >= level && Resource[3] * 5 >= level && Resource[4] * 5 >= level && Resource[5] * 5 >= level && Resource[6] * 5 >= level && Resource[7] * 5 >= level)
                    {
                        Resource[3] += level;
                        Resource[0] -= level * 5;
                        Resource[1] -= level * 5;
                        Resource[2] -= level * 5;
                        Resource[3] -= level * 5;
                        Resource[4] -= level * 5;
                        Resource[5] -= level * 5;
                        Resource[6] -= level * 5;
                        Resource[7] -= level * 5;
                        Produce = Resource[8];
                    }
                }
            }
        }
    }
    public void SendDataInput(GameObject FactoryOutput)
    {

        string FI = this.GetComponent<FactoryInfo>().FactoryName;
        string FO = FactoryOutput.GetComponent<FactoryInfo>().FactoryName;
        {
            GameObject[] temp = new GameObject[Outputsources.Length + 1];
            Outputsources.CopyTo(temp, 0);
            Outputsources = temp;

            Outputsources[Outputsources.Length - 1] = FactoryOutput;

        }
    }
    public void SendDataOutput(GameObject FactoryInput)
    {
        if (MainCamera.GetComponent<ContainVariable>().Workers > 0)
        {
            bool no = true;
            string FO = this.GetComponent<FactoryInfo>().FactoryName;
            string FI = FactoryInput.GetComponent<FactoryInfo>().FactoryName;
            if (FactoryInput.GetComponent<ProduceResource>().Produces)
            {
                for (int i = 0; i < inputRecource.Length; ++i)//     if ((FI == inputRecource1 || FI == inputRecource2 || FI == inputRecource3 || FI == inputRecource4 || FI == inputRecource5 || FI == inputRecource6) || !this.Produces)
                {
  //                  Debug.Log(inputRecource[i]);
                    if ("" + inputRecource[i] == FI)
                    {
                        
                        //               Debug.Log("tttt");


                        GameObject[] temp = new GameObject[Inputsources.Length + 1];
                        Inputsources.CopyTo(temp, 0);
                        Inputsources = temp;

                        Inputsources[Inputsources.Length - 1] = FactoryInput;

                        var Route = Instantiate(RouteA, new Vector3(FactoryInput.transform.position.x, FactoryInput.transform.position.y, FactoryInput.transform.position.z), Quaternion.identity);

                        Route.name = "Route" + this.gameObject.name + "->" + FactoryInput.name;
                        Route.transform.gameObject.SetActive(true);
                        // clone.transform.position
                        Route.transform.parent = RouteCollection.transform;
                        //       Route.GetComponent<Unit>().target = this.gameObject.transform;
                        Route.GetComponent<RouteInfo>().RoutePrimaire = FactoryInput;
                        Route.GetComponent<RouteInfo>().RouteSecondaire = this.gameObject;
                        RoutesList.Add(Route);
                        FactoryInput.GetComponent<ProduceResource>().RoutesList.Add(Route);
                        MainCamera.GetComponent<ContainVariable>().Workers -= 1;
                        if (FactoryInput.GetComponent<Collider>().bounds.Intersects(this.gameObject.GetComponent<Collider>().bounds))
                        {
                            Route.GetComponent<RouteInfo>().Overlapbuildings = true;

                        }
                        no = false;
                        

                    }
                }
                if (no)
                {
                //    Debug.Log(FI);
                    GameObject[] temp = new GameObject[FactoryInput.GetComponent<ProduceResource>().Outputsources.Length - 1];
                    Outputsources.CopyTo(temp, 0);
                    FactoryInput.GetComponent<ProduceResource>().Outputsources = temp;
                }
            }
            else if (!FactoryInput.GetComponent<ProduceResource>().Produces)
            {
                {


                            GameObject[] temp = new GameObject[Inputsources.Length + 1];
                            Inputsources.CopyTo(temp, 0);
                            Inputsources = temp;

                            Inputsources[Inputsources.Length - 1] = FactoryInput;

                            var Route = Instantiate(RouteA, new Vector3(FactoryInput.transform.position.x, FactoryInput.transform.position.y, FactoryInput.transform.position.z), Quaternion.identity);

                            Route.name = "Route" + this.gameObject.name + "->" + FactoryInput.name;
                            Route.transform.gameObject.SetActive(true);
                            // clone.transform.position
                            Route.transform.parent = RouteCollection.transform;
                            //       Route.GetComponent<Unit>().target = this.gameObject.transform;
                            Route.GetComponent<RouteInfo>().RoutePrimaire = FactoryInput;
                            Route.GetComponent<RouteInfo>().RouteSecondaire = this.gameObject;
                            RoutesList.Add(Route);
                            FactoryInput.GetComponent<ProduceResource>().RoutesList.Add(Route);
                            MainCamera.GetComponent<ContainVariable>().Workers -= 1;
                            if (FactoryInput.GetComponent<Collider>().bounds.Intersects(this.gameObject.GetComponent<Collider>().bounds))
                            {
                                Route.GetComponent<RouteInfo>().Overlapbuildings = true;

                            }

                      
                    

                }
            }
        }
    }
    public void sentresourses()
    {

        string FO = this.GetComponent<FactoryInfo>().FactoryName;
        if (this.Produces)
        {
            for (int i = 0; i < Outputsources.Length; ++i)
            {
                {
                    if (Produce > 0)
                    {
                        if (Outputsources[i].GetComponent<ProduceResource>().Resource[1] != null)
                        {
                            for (int j = 0; j < Resource.Length; ++j)
                            {
                                string checknum = "" + j;
                                if (FO == checknum)
                                {
                                    if (Resource[j] > 0)
                                    {
                                        if (Outputsources[i] != null)
                                        {
                                           if (!Outputsources[i].GetComponent<ProduceResource>().Produces)
                                                {
                                                if (Outputsources[i].GetComponent<FactoryInfo>().Harbor)
                                                {
                                                    MainCamera.GetComponent<ContainVariable>().TradeResource[j]++;
                                                }
                                                else
                                                {
                                                    MainCamera.GetComponent<ContainVariable>().GlobalResource[j]++;
                                                }
                                            }
                                            else
                                            {
                                                Outputsources[i].GetComponent<ProduceResource>().Resource[j]++;
                                            }
                                            Resource[j]--;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (!this.Produces)
        {
            for (int i = 0; i < Outputsources.Length; ++i)
            {

                for (int j = 0; j < Resource.Length; ++j)
                {
                    if (Outputsources[i].GetComponent<ProduceResource>().inputRecource[j] != -999 && MainCamera.GetComponent<ContainVariable>().GlobalResource[j] > 0)
                    {

                        if (Outputsources[i] != null)
                        {
                            Outputsources[i].GetComponent<ProduceResource>().Resource[j]++;

                            MainCamera.GetComponent<ContainVariable>().GlobalResource[j]--;
                        }




                    }
                }

            }

        }


    } 
}
