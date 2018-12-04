//------------------------------------------------------------------------------------------
// Filename:        Billboard.cs
//
// Description:     Sets the object this is attached to's transform to be looking at the 
//                  main camera every frame.
//
// Author:          Nathan Nette     
// Editors:         Nathan Nette
//------------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        // Execute billboard function.
        BillboardObject(gameObject);
    }

    /// <summary>
    /// Every frame, set this gameobject's transform to look at the camera.
    /// </summary>
    /// <param name="Go">Intended to be this.gameObject.</param>
    private void BillboardObject(GameObject Go)
    {
        Go.transform.LookAt(-Camera.main.transform.position, Vector3.up);
    }
}
