using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestingScript : MonoBehaviour
{
    [Tooltip("The drop down box to populate with flags")]
    public Dropdown dropDown;

    [Tooltip("The flag of the languages that our game supports")]
    public Sprite[] flags = new Sprite[4] ;

    public Text selectName;
    List<string> names = new List<string>()
        {"A", "B", "C", "D","" };


    List<string> description = new List<string>()
    { "Spent 24 hours" +
        "I need more hours with you" +
        "You spent the weekend" +
        "Getting even, ooh ooh" +
        "We spent the late nights" +
        "Making things right, between us" +
        "But now it's all good baby" +
        "Roll that Backwood baby" +
        "And play me close", "hello", "how are you", "fine",""
    };

    //public string flagName;

    List<Dropdown.OptionData> flagItems =
           new List<Dropdown.OptionData>();

    void flagList()
    {
        for (int i = 0; i < 1; i++)
        {
            string flagName = (names[i]);
            foreach (var flag in flags)
            {
                flag.name = flagName;
                var flagOption = new Dropdown.OptionData(flag.name, flag);
                flagItems.Add(flagOption);
                flagName = (names[i + 1]);
                flag.name = flagName;
                i = i + 1;
            }
            dropDown.AddOptions(flagItems);
        }
    }



    public void Dropdown_IndexChanged(int index)
    {
        //if (index > 0)
        selectName.text = names[index] + ":" + description[index];
    }

    private void Awake()
    {
        flagList();
    }
    /*private void Start()
    {
        flagList();  
    }*/
    /*private void Start()
    {
        //dropDown.ClearOptions();
       

       

        dropDown.AddOptions(flagItems);
    }*/
}
