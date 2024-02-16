using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public CubeMovement player; // Assuming CubeMovement is the script attached to your player
    public Transform target; // Reference to the player's transform
    public Vector3 offset = new Vector3(0f, 2f, -5f); // Offset to set the desired camera position relative to the player

    void Start()
    {
        // Assuming the player object is tagged as "Player"
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            // Get the player's CubeMovement script
            player = playerObject.GetComponent<CubeMovement>();
            // Set the target to the player's transform
            target = player.transform;
        }
        else
        {
            Debug.LogError("Player not found. Make sure your player object is tagged as 'Player'.");
        }
    }

    void Update()
    {
        if (target != null)
        {
            // Set the camera position to follow the player with the specified offset
            transform.position = target.position + offset;

            // Make the camera look at the player
            transform.LookAt(target);
        }
    }
}
