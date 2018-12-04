using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject[] m_Positions;

    private int m_currentPos = 0;
    private int m_previousPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //for debug
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_currentPos++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_currentPos--;
        }

        InputCheck();

        // allocate the position to the currentpos array index of currentpos
        //if (m_previousPos != m_currentPos)
        //{
        gameObject.transform.position = m_Positions[m_currentPos].transform.position;
        //gameObject.transform.position = new Vector3(Mathf.Lerp(gameObject.transform.position.x, m_Positions[m_currentPos].transform.position.x, 1f), gameObject.transform.position.y);
        //Mathf.Lerp(gameObject.transform.position.y, m_Positions[m_currentPos].transform.position.y, 0.1f);
        //}
        m_previousPos = m_currentPos;
    }

    // Input check
    private void InputCheck()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].position.x > (Camera.main.pixelWidth / 2))
            {
                MoveRight();
            }
            else if(Input.touches[0].position.x < (Camera.main.pixelWidth / 2))
            {
                MoveLeft();
            }
        }
    }

    private void MoveRight()
    {
        if(m_currentPos < 3)
        {
            m_currentPos++;
        }
    }

    private void MoveLeft()
    {
        if(m_currentPos > 0)
        {
            m_currentPos--;
        }
    }
}
