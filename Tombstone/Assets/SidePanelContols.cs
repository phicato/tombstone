using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SidePanelContols : MonoBehaviour
{
    public Button btnNapisy;
    public Button btnKrzyze;
    public Button btnKrzyzeMetalowe;
    public Button btnFotografie;
    public GameObject[] panele;
    public ScrollRect scrollrect;

    void Start()
    {
        btnNapisy.GetComponent<Button>().onClick.AddListener(() => OpenPanel(0));
        btnKrzyze.GetComponent<Button>().onClick.AddListener(() => OpenPanel(1));
        btnKrzyzeMetalowe.GetComponent<Button>().onClick.AddListener(() => OpenPanel(2));
        btnFotografie.GetComponent<Button>().onClick.AddListener(() => OpenPanel(3));
        CloseAllPanels();
    }


    void CloseAllPanels()
    {
        foreach (var panel in panele)
        {
            panel.SetActive(false);
        }
    }
    void OpenPanel(int panelIndex)
    {
        if(panele[panelIndex].activeInHierarchy)
        {
            panele[panelIndex].SetActive(false);
        }
        else
        {
            CloseAllPanels();
            panele[panelIndex].SetActive(true);
            scrollrect.content = panele[panelIndex].GetComponent<RectTransform>();
        }
    }
}
