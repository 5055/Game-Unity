using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellResource : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < this.GetComponent<ContainVariable>().TradeResource.Length; i++)
            if (this.GetComponent<ContainVariable>().TradeResource[i] > 0)
            {
                sellit(i);

            }

    }
    void sellit(int i)
    {
        this.GetComponent<ContainVariable>().TradeResource[i] += - 1  ;

        this.GetComponent<ContainVariable>().money += this.GetComponent<ContainVariable>().value[i];

    }
}
