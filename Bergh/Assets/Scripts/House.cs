using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour {
    public GameObject MainCamera;
    // Use this for initialization
    void Start () {
        MainCamera.GetComponent<ContainVariable>().Workers += 4;


    }
}
