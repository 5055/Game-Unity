using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHeckButtonChange : MonoBehaviour
{
    public Dropdown mainSlider;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        mainSlider.value = mainSlider.options.Count - 1;
    }
    public void OnPointerClick()
    {
    //    mainSlider.options.RemoveAt(5);
    }


    // Invoked when the value of the slider changes.
    public void ValueChangeCheck()
    {
   //     Debug.Log(mainSlider.value);
        this.GetComponent<initiate_button>().SpawnFactory(mainSlider.value);
        mainSlider.value = mainSlider.options.Count-1;
    }
}
