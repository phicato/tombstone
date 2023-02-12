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
    public Button btnDelete;
    public GameObject panelWlasciwosci;
    public Slider[] allsliders;
    public TMP_InputField inpWriting;


    void Start()
    {
        btn.onClick.AddListener(() => TogglePanelWlasciwosci());
        btnDelete.onClick.AddListener(() => DeleteNapisComponent());
        ChangeText();
        TogglePanelWlasciwosci();
    }

    void DeleteNapisComponent()
    {
        Destroy(tekst1.transform.parent.gameObject);
        Destroy(this.gameObject);
    }

    void TogglePanelWlasciwosci()
    {
        if (panelWlasciwosci.activeInHierarchy)
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 70);

        }
        else
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 460);
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

    public void SetText1(GameObject t1)
    {
        tekst1 = t1.GetComponentInChildren<TextMeshProUGUI>();
        tekst1.text = "Siema";
    }

}
