using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
public class BtnNowyDodatek : MonoBehaviour
{
    public Transform dodatekComponentParentUI;
    public Transform dodatekNaNagrobkuParent;
    public GameObject dodatekComponentPrefab;
    public GameObject dodatekPrefab;
    GameObject dodatekComponent;
    GameObject dodatek;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => AddNapisComponent());
    }

    void AddNapisComponent()
    {
        dodatekComponent = Instantiate(dodatekComponentPrefab, dodatekComponentParentUI);
        dodatek = Instantiate(dodatekPrefab, dodatekNaNagrobkuParent);
        dodatekComponent.GetComponent<DodatekComponent>().SetDodatek(dodatek);
    }
}
