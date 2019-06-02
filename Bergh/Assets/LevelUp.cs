using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour
{

    int level;
    int experience;
    int experienceNeededToLevelUp;

    public Slider levelUpBar;
    public Text currentLevel;
    public GameObject Xpslider, Maincamera;

    // Use this for initialization
    void Start()
    {
        level = 1;
        experience = 0;
        experienceNeededToLevelUp = 10;

        levelUpBar.value = experience;
        levelUpBar.maxValue = experienceNeededToLevelUp;

        currentLevel.text = "Level 1";
    }

    // Update is called once per frame
    void Update()
    {
    //    int money = 1;
     //   Xpslider.GetComponent<LevelSystem>().UpdateXp(money);
            experience = Maincamera.GetComponent<ContainVariable>().money; ;
            levelUpBar.value = experience;
  

        if (levelUpBar.value >= levelUpBar.maxValue)
        {
            IncreaseLevel();
        }
    }

    void IncreaseLevel()
    {
        Maincamera.GetComponent<ContainVariable>().money = 0;
        levelUpBar.value = experience;

        experienceNeededToLevelUp += 10;
        levelUpBar.maxValue = experienceNeededToLevelUp;

        level += 1;
        currentLevel.text = "Level " + level.ToString();
    }
}
