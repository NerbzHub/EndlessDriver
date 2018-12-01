using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    

    // Empty gameobjects for positions of the ones in the scene.
    public GameObject goSpawnTile = null;

    public GameObject[] m_arrTiles = null;
    // Array of gameobjects for the tiles.
    public static GameObject[] s_arrTiles = null;

    // Use this for initialization
    void Start()
    {
        s_arrTiles = m_arrTiles;
    }

    static public void CreateTile()
    {
        
        // instantiate a new tile at the start position.
        Instantiate(s_arrTiles[Random.Range(0, (s_arrTiles.Length - 1))]);
    }
}
