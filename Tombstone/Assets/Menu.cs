using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject[] panels;
    [SerializeField] Button[] panelBtns;

    void Start()
    {

        CloseAllPanels();
        foreach(Button btn in panelBtns)
        {
            btn.onClick.AddListener(() => TogglePanel(int.Parse(btn.gameObject.name.Substring(0,1))));
        }
    }

    public void TogglePanel(int index)
    {
        if (panels[index].activeInHierarchy)
        {
            panels[index].SetActive(false);
        }
        else
        {
            CloseAllPanels();
            panels[index].SetActive(true);
        }
    }

    void CloseAllPanels()
    {
        foreach (var panel in panels)
        {
            panel.SetActive(false);
        }
    }

}
