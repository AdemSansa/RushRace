using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBehaviour : MonoBehaviour
{
    public Text Mytext;
    int number=0;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            number++;
            Mytext.text = number.ToString();    

        }


        
    }
}
