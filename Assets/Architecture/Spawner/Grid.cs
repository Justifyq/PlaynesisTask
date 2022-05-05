using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public float X = 24, Y = 0.58f, Z = 24;
    private Vector3[] _spawnPoints;

    private void Awake()
    {
        //_spawnPoints.Initialize();
      //  List<Vector3> _spawnPoints = new List<Vector3>();
       // MakeGrid();
        Debug.Log(_spawnPoints);
    }
    private void Start()
    {
        MakeGrid();
    }
    private void MakeGrid()
    {
        int localCounter = 0;
        for (int i = (int)-X; i < (int)Z; i+=2)
        {

            for(int j = (int)-Z; j < (int)Z; j+=2)
            {
                localCounter++;
                Debug.Log(i + "." + Y + "." + j);
                Vector3 spawnPoint = new Vector3(i, Y, j);
                _spawnPoints[localCounter] = spawnPoint;
            }
        }
    }
}
