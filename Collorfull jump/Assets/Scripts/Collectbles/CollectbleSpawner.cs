using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectbleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject collectblePrefab;
    [SerializeField] private CollectblesRespawnLocations respawnLocations;
    
    void Start()
    {
        respawnLocations = GetComponent<CollectblesRespawnLocations>();
        var spawners = respawnLocations.GetSpawners();
    }
    
}
