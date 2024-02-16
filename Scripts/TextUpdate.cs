using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text myText;

    void Start()
    {
        // Assuming you have a Text component attached to the same GameObject as this script
        if (myText == null)
        {
            myText = GetComponent<Text>();
        }

        // Change the text value
        if (myText != null)
        {
            myText.text = "Hello, Unity!";
        }
    }

    void Update()
    {
        // You can change the text continuously in the Update method or based on some condition
        // For example, changing the text every second
        if (Time.time % 2.0f < 1.0f)
        {
            myText.text = "Text is changing!";
        }
        else
        {
            myText.text = "Hello, Unity!";
        }
    }
}
