using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class initiate_button : MonoBehaviour {
    public ContainVariable initiate;
    public GameObject Factorymap;
    public Rigidbody FactoryA, FactoryB, FactoryC, FactoryD, FactoryE, FactoryF, FactoryG, FactoryH, FactoryI, HouseA, StorageA,HarborA;
    private Vector3 mousepos;
    public void SpawnFactory(int FactoryType)
    {
        string FactoryName = "";
        string DisplayName = "";
        Rigidbody FactoryR;
        // if (FactoryType == 0)
        {
            FactoryR = FactoryA;
            FactoryName = "0F";
            DisplayName = "wood";
        }
        if (FactoryType == 1)
        {
            FactoryR = FactoryB;
            FactoryName = "1F";
            DisplayName = "stone";
        }
        if (FactoryType == 2)
        {
            FactoryR = FactoryC;
            FactoryName = "2F";
        }
        if (FactoryType == 3)
        {
            FactoryR = FactoryD;
            FactoryName = "3F";
        }
        if (FactoryType == 4)
        {
            FactoryR = FactoryE;
            FactoryName = "4F";
        }
        if (FactoryType == 5)
        {
            FactoryR = FactoryF;
            FactoryName = "5F";
        }
        if (FactoryType == 6)
        {
            FactoryR = FactoryG;
            FactoryName = "6F";
        }
        if (FactoryType == 7)
        {
            FactoryR = FactoryH;
            FactoryName = "7F";
        }
        if (FactoryType == 8)
        {
            FactoryR = FactoryI;
            FactoryName = "8F";
        }
        if (FactoryType == 9)
        {
            FactoryR = HouseA;
            FactoryName = "3H";
            DisplayName = "House";
        }
        if (FactoryType == 10)
        {
            FactoryR = StorageA;
            FactoryName = "3S";
        }
        if (FactoryType == 11)
        {
            FactoryR = HarborA;
            FactoryName = "4H";
        }

        if (FactoryType<12) {
            mousepos = Input.mousePosition;
            mousepos.z = 0;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            var clone = Instantiate(FactoryR, new Vector3(mousepos.x, mousepos.y, 99), Quaternion.identity);
            clone.transform.Rotate(0, 0, 180, Space.Self);
            clone.name = FactoryName + initiate.FactoryNum;
            clone.transform.gameObject.SetActive(true);
            clone.GetComponent<SelectFactory>().DisplayName =DisplayName;
            // clone.transform.position
            clone.transform.parent = Factorymap.transform;
        }
    }
}
