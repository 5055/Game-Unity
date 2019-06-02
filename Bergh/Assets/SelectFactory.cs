using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFactory : MonoBehaviour {
    public GameObject CurrentLevel;
    public string DisplayName;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            CurrentLevel.GetComponent<Poof>().SelectedFactory = this.gameObject;
        CurrentLevel.GetComponent<Poof>().NameFactory.text = DisplayName;
        CurrentLevel.GetComponent<Poof>().LevelNiv.text = "" + this.gameObject.GetComponent<FactoryInfo>().level;

    }
    }

