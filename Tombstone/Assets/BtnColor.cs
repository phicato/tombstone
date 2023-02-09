using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BtnColor : MonoBehaviour
{
    AppManager appManager;


    void Start()
    {
        appManager = FindObjectOfType<AppManager>();
        this.GetComponent<Button>().onClick.AddListener(() => GetMaterial());
    }

    void GetMaterial()
    {
        Material mat = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().material;
        appManager.GetActiveGameObject().gameObject.GetComponent<Renderer>().material = mat;
    }

}
