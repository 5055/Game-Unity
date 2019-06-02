using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownExample : MonoBehaviour {
	public Dropdown dropdown;

	void Awake(){
		PopulateList ();

	}

	void PopulateList(){
		List<string> names = new List<string> ()
		{ "Stonecutter", "Woodcutter", "Toolmaker", "Factory3", "Factory4", "Factory5", "Factory6", "Factory7", "Factory8", "House","Storage","Harbor", "Select Factory" };
		dropdown.AddOptions (names);
	}

}
