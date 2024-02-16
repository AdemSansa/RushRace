using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bomb : MonoBehaviour
{


    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        ScoreManager.scoreCount--;
        if(ScoreManager.scoreCount<=0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        // Add any additional actions to end the game, such as showing a game over screen or restarting the level.
        // For example, you can reload the current scene:
        SceneManager.LoadScene("GameOver");
    }    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
