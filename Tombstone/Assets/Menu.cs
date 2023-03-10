using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public static Menu Instance { get; private set; }

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


    void Start()
    {
        PrepareGraveElementsMenu(walls3DObjects, wallsMenu, -100f, 0.9f, 1.1f);
        PrepareGraveElementsMenu(tops3DObjects, topsMenu, -35f, 1.72f, 1.3f);
        PrepareGraveElementsMenu(curbs3DObjects, curbsMenu, -30f, 1.9f, 0.9f);
        PrepareGraveElementsMenu(topExtras3DObjects, topExtrasMenu, -100f, 0.94f, 0.8f);
        PrepareMaterialMenu();
        CloseAllPanels();
    }


    [SerializeField] Material[] materials;
    [SerializeField] GameObject[] walls3DObjects;    
    [SerializeField] GameObject[] tops3DObjects;
    [SerializeField] GameObject[] curbs3DObjects;
    [SerializeField] GameObject[] topExtras3DObjects;
    [SerializeField] GameObject stoneColorPanel;
    [SerializeField] GameObject decorationsColorPanel;

    [SerializeField] GameObject materialItem;
    [SerializeField] GameObject[] panels;
    [SerializeField] Transform ColorPanel;
    [SerializeField] Transform wallsMenu;
    [SerializeField] Transform topsMenu;
    [SerializeField] Transform curbsMenu;
    [SerializeField] Transform topExtrasMenu;
    [SerializeField] Transform wallDecorationsMenu;

    public GameObject[] GetWall3dList()
    {
        return walls3DObjects;
    }
    public GameObject[] GetTop3dList()
    {
        return tops3DObjects;
    }
    public GameObject[] GetCurb3dList()
    {
        return curbs3DObjects;
    }
    // Enable grave item after menu icon clicked
    public void EnableGraveItem(string cat, int index)
    {
        GameObject[] items = walls3DObjects;
        if (cat == "t")
        {
            items = tops3DObjects;
        }
        else if(cat == "c")
        {
            items = curbs3DObjects;
        }
        else if (cat == "e")
        {
            items = topExtras3DObjects;
        }

        foreach (GameObject item in items)
        {
            item.SetActive(false);
        }
        items[index].SetActive(true);
    }

    //creates material menu
    void PrepareMaterialMenu()
    {
        float itemSpacer = 0.6f;
        Vector2 itemStartPos = new Vector2(-4f, 0f);
        Vector3 startRotation = new(-100, -10f, 0);
        float itemScale = 0.7f;
        for (int i=0; i < materials.Length; i++)
        {
            GameObject menuItem = Instantiate(materialItem, itemStartPos, Quaternion.Euler(startRotation), ColorPanel);
            menuItem.transform.localScale = new Vector3(itemScale, itemScale, itemScale);
            menuItem.transform.localPosition = new Vector3(itemStartPos.x, 0f, 0f);
            menuItem.SetActive(true);
            menuItem.AddComponent<BoxCollider>();
            menuItem.AddComponent<ColorItem>();
            menuItem.GetComponent<MeshRenderer>().material = materials[i];
            itemStartPos.x += itemSpacer;
        }
    }

    //creates menu with 3d objects
    void PrepareGraveElementsMenu(GameObject[] gElements, Transform gMenu, float startRot, float startPosY, float spacerY)
    {
        float itemSpacer = 1.2f;
        Vector2 itemStartPos = new(-4f, startPosY);
        int itemsInTheRow = 5;
        Vector3 startRotation = new(startRot, 0, 0);

        for (int i = 0; i < gElements.Length; i++)
        {
            GameObject menuItem = Instantiate(gElements[i], itemStartPos, Quaternion.Euler(startRotation), gMenu);
            menuItem.SetActive(true);
            if (menuItem.name[2..3] == "e")
            {
                menuItem.transform.localScale = Vector3.one * 3;
            }
            //menuItem.AddComponent<BoxCollider>();
            menuItem.AddComponent<MenuItem>();

            Destroy(menuItem.GetComponent<GItem>());

            MeshRenderer[] innerItems = menuItem.GetComponentsInChildren<MeshRenderer>();
            for (int j = 0; j < innerItems.Length; j++)
            {
                innerItems[j].material = materials[j];
                innerItems[j].gameObject.AddComponent<MenuItemMesh>();
                Destroy(innerItems[j].GetComponent<GItem>());

            }

            if (i == itemsInTheRow - 1 || i == itemsInTheRow*2 - 1)
            {
                itemStartPos += new Vector2(-itemSpacer * (itemsInTheRow - 1), -spacerY);
            }
            else
            {
                itemStartPos.x += itemSpacer;

            }

        }
    }


    public Transform activePanel { get; private set; }


    public void TogglePanel(int index)
    {
        if (panels[index].activeInHierarchy)
        {
            panels[index].SetActive(false);
            activePanel = null;
            stoneColorPanel.SetActive(false);
            decorationsColorPanel.SetActive(false);
        }
        else
        {
            CloseAllPanels();
            panels[index].SetActive(true);
            activePanel = panels[index].transform;
            if (index < 5)
            {
                stoneColorPanel.SetActive(true);
            }
            else
            {
                decorationsColorPanel.SetActive(true);
            }
        }
    }

    void CloseAllPanels()
    {
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
        stoneColorPanel.SetActive(false);
        decorationsColorPanel.SetActive(false);
    }

}
