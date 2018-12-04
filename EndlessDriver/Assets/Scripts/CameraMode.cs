using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMode : MonoBehaviour
{
    enum ENUMCAMERAMODE
    {
        THIRDPERSON = 0,
        FIRSTPERSON,
        COUNT
    }

    // This array stores the third person game object and the first person gameobject.
    public GameObject[] m_CarModes;

    private ENUMCAMERAMODE camMode;
    private ENUMCAMERAMODE previousMode;

    // Use this for initialization
    void Start()
    {
        camMode = ENUMCAMERAMODE.THIRDPERSON;
        previousMode = ENUMCAMERAMODE.THIRDPERSON;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (camMode == ENUMCAMERAMODE.FIRSTPERSON)
                camMode = ENUMCAMERAMODE.THIRDPERSON;
            else
                camMode = ENUMCAMERAMODE.FIRSTPERSON;
        }
        if (previousMode != camMode)
        {
            ToggleCam();
        }
        previousMode = camMode;
    }

    private void ToggleCam()
    {
        m_CarModes[(int)camMode].SetActive(true);
        m_CarModes[(int)previousMode].SetActive(false);
    }
}
