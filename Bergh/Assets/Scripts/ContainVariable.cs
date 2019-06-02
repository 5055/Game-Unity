using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainVariable : MonoBehaviour {
    public int FactoryNum = 0;
    public bool DestroyMode = false;
    public int Workers =0;
    public int level = 1;
    public int exp;
    public int[] GlobalResource;
    public int[] TradeResource;
    public int[] import;
    public int[] value;
    public int money =0;
    public GameObject Xpslider;

    public void setDestroyMode()
    {
        if (DestroyMode)
        {
            DestroyMode = false;
        }
        else if (!DestroyMode)
        {
            DestroyMode = true;
        }
    //    Debug.Log(DestroyMode);
    }

    void Update()
    {
        Xpslider.GetComponent<LevelSystem>().UpdateXp(money);
      //  levelup();
      //  exp += 1;
    }
    public void levelup()
    {
        if(exp > level* 30+ 100)
        {
            exp -= (level *30 +100);
            level = level + 1;

        }

    }
}
