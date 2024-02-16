using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerScript : MonoBehaviour
{
    public Text Score;
    int number;
    private void OnTriggerEnter(Collider other )
    {

        var player = other.GetComponent<CubeMovement>();
        if ( player != null)
        {
            number++;
            print("triggered ");
            Destroy(gameObject);
            Score.text = number.ToString();   
        }


    }
}
