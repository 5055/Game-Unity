using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour {


	public int XP;
	public int currentlevel;

	void Update () {
//		UpdateXp (2000);
	}
	public void UpdateXp(int xp){
		XP += xp;

		int ourlvl = (int)(0.1f + Mathf.Sqrt ((XP)));

		if(ourlvl != currentlevel)
		{
			currentlevel = ourlvl;
			// add some cool text to show level up!!
		}

		int xpnextlevel = 100 * (currentlevel + 1) * (currentlevel + 1);
		int differencexp = xpnextlevel - XP;

		int totaldifference = xpnextlevel - (100 * currentlevel * currentlevel);
		// differencexp / totaldifference;
	}
}

