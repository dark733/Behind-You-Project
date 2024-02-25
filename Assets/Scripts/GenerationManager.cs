using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GenerationManager : MonoBehaviour
{
    [SerializeField] public Transform WorldGrid;
    [SerializeField] public GameObject roomPrefab;
    public int mapSize = 16;
    public int mapSizeSquare;
    private Vector3 currentPos;
    private int currentPosX, currentPosY;
    private int positionTracker;

    public void Update()
    {
        mapSizeSquare = (int)Mathf.Sqrt(mapSize);
    }

    public void GenerateWorld()
    {
        for (int i = 0; i < mapSize; i++)
        {
            Instantiate(roomPrefab, currentPos, Quaternion.identity, WorldGrid);
        }
    }

    public void ReloadWorld()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
