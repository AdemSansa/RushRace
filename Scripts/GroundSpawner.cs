

using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public static GroundSpawner instance;

    public GameObject groundTile;
    Vector3 nextSpawnPoint;
    public int groundsToSpawn;


private void Awake() {
    instance=this;
}

    void spawnTile()
    {
        for (int i = 0; i < groundsToSpawn; i++)
        {
        GameObject temp = Instantiate(groundTile,nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetComponent<RoadPart>().nextSpawnPoint.position ;
        }
        

    }
    // Start is called before the first frame update
    void Start()
    {
        spawnTile();
        

        
    }

    public void AddRoadPart()
    {
        GameObject temp = Instantiate(groundTile,nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetComponent<RoadPart>().nextSpawnPoint.position ;
    }

   




}
