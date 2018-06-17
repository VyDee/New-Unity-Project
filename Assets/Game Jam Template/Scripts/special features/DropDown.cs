using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DropDown : MonoBehaviour
{
    List<string> wnames = new List<string>()
    { "A", "B", "C", "D" };

    List<string> description = new List<string>()
    { "hi", "hello", "how are you", "fine" };

    //List<Dropdown.OptionData> weaponItems = 
        //new List<Dropdown.OptionData>();

    public Dropdown dropdown;
    public Text selectName;

    //public Sprite[] weapons;

    public void Dropdown_IndexChanged(int index)
    {
        selectName.text = wnames[index] + ":" + description[index];
    }

    /*public void Image_IndexChanged(int index)
    {
        foreach (var weapon in weapons)
        {
            var weaponOption =
                new Dropdown.OptionData(wnames[index], weapon);
            weaponItems.Add(weaponOption);
        }
    }*/

    private void Start()
    {
        PopulateList();
        //dropdown.ClearOptions();
    }

    void PopulateList()
    { 
        dropdown.AddOptions(wnames);
       //dropdown.AddOptions(weaponItems);
    }







}