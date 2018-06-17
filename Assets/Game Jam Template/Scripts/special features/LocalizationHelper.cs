using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizationHelper : MonoBehaviour
{
    [Tooltip("The drop down box to populate with flags")]
    public Dropdown dropDown;

    [Tooltip("The flag of the languages that our game supports")]
    public Sprite[] flags;

    public Text selectName;
    //List<string> names = new List<string>()
    //{ "A", "B", "C", "D" };

    List<string> description = new List<string>()
    { "hi", "hello", "how are you", "fine" };

    //public string flagName;

    List<Dropdown.OptionData> flagItems =
           new List<Dropdown.OptionData>();

    void flagList ()
    {   
        foreach (var flag in flags)
        {
            string flagName = flag.name;
            
            var flagOption =
                new Dropdown.OptionData(flag.name, flag);
            flagItems.Add(flagOption);
            Debug.Log(flagItems);

        }
    }

    public void Dropdown_IndexChanged(int index)
    {
        selectName.text = 
            flagItems[index] + ":" + description[index];
    }

    private void Awake()
    {
        flagList();
        dropDown.AddOptions(flagItems);
    }
    /*private void Start()
    {
        //dropDown.ClearOptions();
       

       

        dropDown.AddOptions(flagItems);
    }*/
}
