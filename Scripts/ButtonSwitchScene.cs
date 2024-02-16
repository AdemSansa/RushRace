using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneSwitcher : MonoBehaviour
{
    public string targetSceneName;

    public void OnButtonPressed()
    {
        SceneManager.LoadScene(targetSceneName);
    }
    private void Start() {
        Button button = GetComponent<Button>();

        // Check if the Button component exists
        if (button != null)
        {
            // Add a listener to the Button's onClick event
            button.onClick.AddListener(OnButtonPressed);
        }
        else
        {
            Debug.LogError("Button component not found on " + gameObject.name);
        }
    }

    
}