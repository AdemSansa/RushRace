using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]float remainingTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime-=Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime/60);
        int Seconds = Mathf.FloorToInt(remainingTime%60);
        timerText.text = string.Format("{0:00}:{1:00}",minutes,Seconds);
        if (remainingTime<0)
        {
            SceneManager.LoadScene("GameOver");
        }

    }
}
