using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DecorationsColors : MonoBehaviour
{
    [SerializeField] Color[] colors;
    [SerializeField] MenuWallDecoration menuWallDEcoration;
    [SerializeField] MenuInscription menuInscription;
    [SerializeField] GameObject btnColorPrefab;
    [SerializeField] Transform colorBtnPanel;
    void Start()
    {
        CreatePanelButtons();
    }

    public void CreatePanelButtons()
    {
        for (int i = 0; i < colors.Length; i++)
        {
            GameObject btn = Instantiate(btnColorPrefab, colorBtnPanel);
            btn.GetComponent<Image>().color = colors[i];
            btn.GetComponent<Button>().onClick.AddListener(() => PickDecorationColor());
        }
    }

    public void PickDecorationColor()
    {
        Color col = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
        menuWallDEcoration.ChangeColor(col);
        menuInscription.ChangeColor(col);
    }
}
