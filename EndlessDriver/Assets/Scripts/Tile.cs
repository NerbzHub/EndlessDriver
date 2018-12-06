using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public Vector3 v3MoveAmount = Vector3.zero;

    private float fDiffOfZAmount;
    private Vector3 v3SpwnPosWDiff;

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveTile();
        if (gameObject.transform.position.z <= -200)
        {
            fDiffOfZAmount = gameObject.transform.position.z + 200;
            // going to have to accomodate for the difference if it's over 200.
            Debug.Log(fDiffOfZAmount);
            v3SpwnPosWDiff.z = TileManager.SpawnPosition.transform.position.z + fDiffOfZAmount;

            //gameObject.transform.position = TileManager.SpawnPosition.transform.position;
            Instantiate(gameObject, v3SpwnPosWDiff, Quaternion.identity);
            //gameObject.transform.position = new Vector3(0, 1000, 0);
            //foreach (GameObject in gameObject.ch)
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        

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
