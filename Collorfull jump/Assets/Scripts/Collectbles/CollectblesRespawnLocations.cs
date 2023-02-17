using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectblesRespawnLocations : MonoBehaviour
{
   [SerializeField] List<Transform> spawners = new List<Transform>();

    public List<Transform> GetSpawners()
    {
        return spawners;
    }
}
