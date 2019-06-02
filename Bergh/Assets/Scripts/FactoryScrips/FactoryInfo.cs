using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryInfo : MonoBehaviour
{
    public bool House, Storage, Harbor;
    public string FactoryName = "";
    public List<GameObject> Connections = new List<GameObject>();
    public int level;
    public GameObject MainCamera;

    void Start()
{
        int LetterCount=0;
        while (this.name[LetterCount] > 47 && this.name[LetterCount]< 58)
        {
    FactoryName = FactoryName + this.name[LetterCount];
            LetterCount++;
}
   //     Debug.Log(FactoryName);

    }
    private void Update()
    {
        
    }
    public void levelup()
    {
        bool BlockLevelUp = false;
        for (int i = 0; i < this.gameObject.GetComponent<BuildCost>().Buildcost.Length; ++i)
        {
            if (this.gameObject.GetComponent<BuildCost>().Buildcost[i]* Mathf.Pow(2, level-1) > MainCamera.GetComponent<ContainVariable>().GlobalResource[i])
            {
                BlockLevelUp = true;
            }
        }
        if (!BlockLevelUp)
        {
            level += 1;
            for (int i = 0; i < this.gameObject.GetComponent<BuildCost>().Buildcost.Length; ++i)
            {
                MainCamera.GetComponent<ContainVariable>().GlobalResource[i] -= (int)(this.gameObject.GetComponent<BuildCost>().Buildcost[i] * Mathf.Pow(2, level - 2));

            }
        }
    }
}
