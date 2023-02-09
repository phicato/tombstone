using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    Camera cam;
    GameObject activeObject;

    void Start()
    {
        cam = Camera.main;
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
                Debug.Log(activeObject.name);
            }
        }
    }
}
