using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    const float GridY = 0.58f;
    public AllObjectsData ObjectsData;
    public SpawnPointsData SpawnConfig;
    public bool LoadFromConfig;
    [HideInInspector] 
    public int GridX = 23, GridZ = 23, Offset = 2;
    public int ObjectsCount = 3;

    private void Awake()
    {
        if (LoadFromConfig)
        {
            if (SpawnConfig != null)
            {
                if (SpawnConfig.SpawnPoints.Length != 0)
                    SpawnFromConfig();
                else
                    SpawnFromRandom();
            }
            else
            {
                SpawnFromRandom();
            }
        }
        else
        {
            SpawnFromRandom();
        }
            
    }

    private void SpawnObject(GameObject interactiveObj, Vector3 position)
    {
        Instantiate(interactiveObj, position, Quaternion.identity);
    }

    private void SpawnFromConfig()
    {
        var spawnPoints = SpawnConfig.SpawnPoints;
        int objectsCount = spawnPoints.Length;
        for (int i = 0; i < objectsCount; i++)
        {
            SpawnObject(RandomObject(), spawnPoints[i]);
        }
    }

    private void SpawnFromRandom()
    {
        List<Vector3> spawnPoints = GenerateGrid();
        List<Vector3> chosedSpawnPoint = new List<Vector3>();
        for (int i = 0; i < ObjectsCount; i++)
        {
            Vector3 spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Count - 1)];
            SpawnObject(RandomObject(), spawnPoint);
            spawnPoints.Remove(spawnPoint);
        }
    }

    private List<Vector3> GenerateGrid()
    {
        List<Vector3> spawnPoints = new List<Vector3>();
        for (int x = 0; x < GridX; x += Offset)
        {
           for (int z = 0; z < GridZ; z += Offset)
            {
                spawnPoints.Add(new Vector3(x, GridY, z));
            }
        }
        return spawnPoints;
    }

    private GameObject RandomObject()
    {
        GameObject interactiveObj = ObjectsData.Item[Random.Range(0, ObjectsData.Item.Length - 1)];
        return interactiveObj;
    }
}
