using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BtnPomnik : MonoBehaviour
{
    AppManager appManager;

    void Start()
    {
        appManager = FindObjectOfType<AppManager>();
        this.GetComponent<Button>().onClick.AddListener(() => DisplayGrave());
    }

    void DisplayGrave()
    {
        int graveIndex = int.Parse(EventSystem.current.currentSelectedGameObject.name) - 1;
        appManager.DisplayGrave(graveIndex);
    }
}
