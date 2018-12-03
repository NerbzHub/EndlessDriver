using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    // The spawn positions for the cars on the road.
    public GameObject[] m_ThirdSpawnPositions = null;
    public GameObject[] m_SecondSpawnPositions = null;
    public GameObject[] m_FirstSpawnPositions = null;

    public GameObject m_CarPrefab = null;

    // Use this for initialization
    void OnEnable()
    {
        // assign 1 car to each section.
        int rand = Random.Range(0, 3);
        GameObject FirstObCar = new GameObject();
        FirstObCar = Instantiate(m_CarPrefab, m_FirstSpawnPositions[rand].gameObject.transform);
        FirstObCar.transform.localPosition = new Vector3(0, 0, 0);
        FirstObCar.transform.localRotation = Quaternion.identity;
        FirstObCar.transform.GetChild(6).gameObject.GetComponent<MeshRenderer>().materials[1].color = RandomiseColour();

        rand = Random.Range(0, 3);
        GameObject SecondObCar = new GameObject();
        SecondObCar = Instantiate(m_CarPrefab, m_SecondSpawnPositions[rand].gameObject.transform);
        SecondObCar.transform.localPosition = new Vector3(0, 0, 0);
        SecondObCar.transform.localRotation = Quaternion.identity;
        SecondObCar.transform.GetChild(6).gameObject.GetComponent<MeshRenderer>().materials[1].color = RandomiseColour();

        rand = Random.Range(0, 3);
        GameObject ThirdObCar = new GameObject();
        ThirdObCar = Instantiate(m_CarPrefab, m_ThirdSpawnPositions[rand].gameObject.transform);
        ThirdObCar.transform.localPosition = new Vector3(0, 0, 0);
        ThirdObCar.transform.localRotation = Quaternion.identity;
        ThirdObCar.transform.GetChild(6).gameObject.GetComponent<MeshRenderer>().materials[1].color = RandomiseColour();
    }

    private Color RandomiseColour()
    {
        Color randCol = new Color();
        randCol.r = Random.Range(0.0f, 1.0f);
        randCol.g = Random.Range(0.0f, 1.0f);
        randCol.b = Random.Range(0.0f, 1.0f);
        randCol.a = 1.0f;

        return randCol;
    }
}
