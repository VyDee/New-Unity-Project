using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSizeSlider : MonoBehaviour {

    //For this script to work, create a new Text GameObject by going to Create>UI>Text. 
    //Attach the script to the Text GameObject. Make sure the GameObject has a RectTransform component.

    //public Text m_Text;
    RectTransform m_RectTransform;
    public Slider TextSlider;
    //int size;

    /*void Test1()
    {
        void Start()
        {
            //Fetch the Text and RectTransform components from the GameObject
            m_Text = GetComponent<Text>();
            m_RectTransform = GetComponent<RectTransform>();
            TextSlider.value = 12;
        }

        void Update()
        {
            //m_Text.text = "I changed my Font size!";
            //Press the space key to change the Font size
            //if (Input.GetKey(KeyCode.Space))
            {
                changeFontSize();
            //}
            changeFontSize();
        }

        void Example()
        {
            GetComponent<TextMesh>().fontSize = 12;
        }

        void changeFontSize()
        {

            TextSlider.value = size;
            //Change the Font Size to 16
            m_Text.fontSize = size;

            //Change the RectTransform size to allow larger fonts and sentences
            m_RectTransform.sizeDelta = new Vector2(m_Text.fontSize * 10, 100);

            //Change the m_Text text to the message below
            //m_Text.text = "I changed my Font size!";
        }
    }*/
    
}
