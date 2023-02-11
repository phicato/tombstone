using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BtnNowyNapis : MonoBehaviour
{
    public Transform napisComponentParent;
    public Transform napisNaNagrobkuParent;
    public GameObject napisComponentPrefab;
    public GameObject napisPrefab;
    GameObject napisComponent;
    GameObject napis;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => AddNapisComponent());
    }

    void AddNapisComponent()
    {
        napisComponent = Instantiate(napisComponentPrefab, napisComponentParent);
        napis = Instantiate(napisPrefab, napisNaNagrobkuParent);
        
        napisComponent.GetComponent<NapisComponent>().SetText1(napis);
    }
}
