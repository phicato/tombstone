using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SidePanelContols : MonoBehaviour
{
    public Button btnNapisy;
    public Button btnDodatki;
    public GameObject[] panele;
    public ScrollRect scrollrect;

    void Start()
    {
        btnNapisy.GetComponent<Button>().onClick.AddListener(() => OpenPanel(0));
        btnDodatki.GetComponent<Button>().onClick.AddListener(() => OpenPanel(1));
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
        CloseAllPanels();
        panele[panelIndex].SetActive(true);
        scrollrect.content = panele[panelIndex].GetComponent<RectTransform>();
    }
}
