using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poof : MonoBehaviour {

	public Text NameFactory;
	public Text LevelNiv;
	public Text CurrentResources;
    public GameObject SelectedFactory, Maincamera;


	void Start () {
        NameFactory.text = "Name";
        LevelNiv.text = "Level IETS";
   //     CurrentResources.text = "Recourses";

    }
	

	void Update () {


	}
    public void LevelUpBuilding()
    {
        Maincamera.GetComponent<ClickMousebutton>().ActiveInfoBox++;
        SelectedFactory.GetComponent<FactoryInfo>().levelup();
        LevelNiv.text = "" +SelectedFactory.GetComponent<FactoryInfo>().level;



    }
}
