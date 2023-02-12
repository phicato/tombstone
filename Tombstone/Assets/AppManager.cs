using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public Transform pomniki;

    public GameObject[] graves;
    Camera cam;
    GameObject activeObject;

    void Start()
    {
        cam = Camera.main;
        DisplayGrave(0);
    }

    public void DisplayGrave(int graveIndex)
    {
        foreach (GameObject grave in graves)
        {
            grave.SetActive(false);
        }
        graves[graveIndex].SetActive(true);
    }

    public GameObject[] GetAllGraves()
    {
        return graves;
    }

    public GameObject GetActiveGameObject()
    {
        return activeObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                activeObject = hit.collider.gameObject;
            }
        }
    }



}
