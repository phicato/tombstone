using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GAppManager : MonoBehaviour
{
    public static GAppManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    [SerializeField] Transform topMenu;
    [SerializeField] Transform topGrave;
    ItemPick[] tops;


    private void Start()
    {
        tops = topMenu.GetComponentsInChildren<ItemPick>();
    }

    public void SetTop(int index)
    {
        if(topGrave.transform.childCount >= 1)
        {
            Destroy(topGrave.transform.GetChild(0).gameObject);
        }
        GameObject top = Instantiate(tops[index].gameObject, topGrave);
        top.AddComponent<GTop>();
        Destroy(top.GetComponent<ItemPick>());
        top.transform.localPosition = Vector3.zero;
        top.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
    }
}
