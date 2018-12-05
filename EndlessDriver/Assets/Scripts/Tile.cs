using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector3 v3MoveAmount = Vector3.zero;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        MoveTile();
    }
    private void Update()
    {
        if(gameObject.transform.position.z <= -200)
        {
            gameObject.transform.position = TileManager.SpawnPosition.transform.position;
        }

        if(v3MoveAmount.z <= 4.0f)
         v3MoveAmount.z += (TileManager.s_SpeedUpMulti * 0.01f); 
    }

    private void MoveTile()
    {
        gameObject.transform.position -= v3MoveAmount;
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "EndCollider")
    //    {
            
            
    //    }
    //}

    
}
