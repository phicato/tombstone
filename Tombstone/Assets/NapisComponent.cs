using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NapisComponent : MonoBehaviour
{
    public TextMeshProUGUI tekst1;
    public Button btn;
    public GameObject panelWlasciwosci;
    public Slider[] allsliders;
    public TMP_InputField inpWriting;

    void Start()
    {
        btn.onClick.AddListener(() => TogglePanelWlasciwosci());
        ChangeText();
        TogglePanelWlasciwosci();
    }

    void TogglePanelWlasciwosci()
    {
        if (panelWlasciwosci.activeInHierarchy)
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 80);
        }
        else
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 400);

        }
        panelWlasciwosci.SetActive(!panelWlasciwosci.activeInHierarchy);
    }

    public void ChangeTextColor()
    {
        tekst1.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;

    }
    public void ChangeFont()
    {
        tekst1.font = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().font;

    }

    public void ChangeText()
    {
        tekst1.text = inpWriting.GetComponent<TMP_InputField>().text;
        btn.GetComponentInChildren<TMP_Text>().text = tekst1.text.Replace("\n", "");
    }

    public void SetSliders()
    {
        tekst1.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[0].value, tekst1.GetComponent<RectTransform>().anchoredPosition.y);
        tekst1.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[1].value, tekst1.GetComponent<RectTransform>().anchoredPosition.x);
        tekst1.fontSize = allsliders[2].value;
    }


}
