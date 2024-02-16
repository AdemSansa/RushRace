using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesSpawners : MonoBehaviour
{

    public GameObject StarPrefab;
    public GameObject BombPrefab;
    
    
    public void launchcollectible(int maximumBombSpawn){

    }
    public void Spawncollectables()
    {
        int maximumBombSpawn = 2;
        int maximumStarSpawn = 3;
        for (int i = -2; i < 3; i++)
        {
            int obj = Random.Range(0,3); 
            if (obj==0 && maximumStarSpawn!=0)
            {
                GameObject temp =  Instantiate(StarPrefab, transform.position+new Vector3(i*5f,0,0), Quaternion.Euler(130,0,0));
                temp.transform.parent=transform;
                maximumStarSpawn--;

            }else if(obj==1 && maximumBombSpawn!=0){
                GameObject temp =  Instantiate(BombPrefab, transform.position+new Vector3(i*5f,0,0), Quaternion.identity);
                temp.transform.parent=transform;
                maximumBombSpawn--;

            }
           
            
        }
        
        // int starXPosition=Random.Range(-2,3);
        // GameObject temp =  Instantiate(StarPrefab, transform.position+new Vector3(starXPosition*5f,0,0), Quaternion.identity);
        // 
    }







    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Spawncollectables();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
