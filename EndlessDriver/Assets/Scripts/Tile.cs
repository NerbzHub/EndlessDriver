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

    private void MoveTile()
    {
        gameObject.GetComponent<Rigidbody>().MovePosition(gameObject.transform.position -= v3MoveAmount);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EndCollider")
        {
            Debug.Log("hit");
            TileManager.CreateTile();
            Destroy(gameObject);
        }
    }
}
