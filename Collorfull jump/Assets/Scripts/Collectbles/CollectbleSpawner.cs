using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectbleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject collectblePrefab;
    [SerializeField] private CollectblesRespawnLocations respawnLocations;
    CollectbleColor colorPrefab;
    
    void Start()
    {
        colorPrefab = GetComponent<CollectbleColor>();
        respawnLocations = GetComponent<CollectblesRespawnLocations>();
        var spawners = respawnLocations.GetSpawners();
        foreach(var spawner in spawners)
        {
            GameObject instance = Instantiate(collectblePrefab,
                spawner.position,
                Quaternion.identity);
            
        }
    }
    
}
