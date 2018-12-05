using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    // Empty gameobjects for positions of the ones in the scene.
    public GameObject goSpawnPosition = null;
    public GameObject goTile = null;
    public static GameObject SpawnPosition;
    public float fSpeedUpMultiplier = 0;
    public static float s_SpeedUpMulti = 0;

    // Use this for initialization
    void Awake()
    {
        SpawnPosition = goSpawnPosition;
    }
    private void Update()
    {
        s_SpeedUpMulti = fSpeedUpMultiplier;
        
    }
}
