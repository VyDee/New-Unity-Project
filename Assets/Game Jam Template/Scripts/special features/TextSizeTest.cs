using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSizeTest : MonoBehaviour
{

    public Text text;

    Toggle toggle;

    int size;

    void Awake()
    {
        text = GetComponent<Text>();
        toggle = GetComponent<Toggle>();

    }
    
    void Update()
    {

    }

    public void medium(bool newValue)
    {
        if (newValue == true)
        {
            text.fontSize = 18;
        }

    }

    public void large(bool newValue)
    {
        if (newValue == true)
        {
            text.fontSize = 25;
        }

    }
    public void small(bool newValue)
    {
        if (newValue == true)
        {
            text.fontSize = 12;
        }
    }
}
