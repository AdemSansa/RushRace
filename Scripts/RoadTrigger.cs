using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("trigger this");
        if(other.GetComponent<CubeMovement>()!=null)
        {
            GroundSpawner.instance.AddRoadPart();
                    Destroy(transform.parent.gameObject,2f);
        }
    }
}
