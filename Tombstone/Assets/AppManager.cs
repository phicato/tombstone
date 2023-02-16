using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    [SerializeField] Transform pomniki;
    [SerializeField] GameObject[] pomniki3D;
    [SerializeField] Material[] koloryKamieni;
    [SerializeField] Button btnExit;
    public MeshRenderer mr;
    Camera cam;
    GameObject activeObject;

    public void ZakonczApke()
    {
        Application.Quit();
    }

    void Start()
    {
        cam = Camera.main;
        DisplayGrave(0);
        Debug.Log(mr.bounds.size);
    }

    public void DisplayGrave(int graveIndex)
    {
        foreach (GameObject grave in pomniki3D)
        {
            grave.SetActive(false);
        }
        pomniki3D[graveIndex].SetActive(true);
    }

    public GameObject[] GetAllGraves()
    {
        return pomniki3D;
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
