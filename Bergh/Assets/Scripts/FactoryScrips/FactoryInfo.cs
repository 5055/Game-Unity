using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryInfo : MonoBehaviour
{
    public bool House, Storage, Harbor;
    public string FactoryName = "";
    public List<GameObject> Connections = new List<GameObject>();
    public int level;

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
    void update()
    {

    }
}
