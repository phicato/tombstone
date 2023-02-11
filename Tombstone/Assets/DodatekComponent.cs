using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DodatekComponent : MonoBehaviour
{
    public Button btn;
    public Button btnDelete;
    public GameObject panelWlasciwosci;
    public Slider[] allsliders;
    public Image krzyzImage;

    public void SetDodatek(GameObject i)
    {
        krzyzImage = i.GetComponent<Image>();
    }

    void Start()
    {
        btn.onClick.AddListener(() => TogglePanelWlasciwosci());
        btnDelete.GetComponent<Button>().onClick.AddListener(() => UsunComponent());
    }
    void TogglePanelWlasciwosci()
    {
        if (panelWlasciwosci.activeInHierarchy)
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 80);

        }
        else
        {
            this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, 350);
        }
        panelWlasciwosci.SetActive(!panelWlasciwosci.activeInHierarchy);
    }

    public void SetSliders()
    {
        krzyzImage.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[0].value, krzyzImage.GetComponent<RectTransform>().anchoredPosition.y);
        krzyzImage.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[1].value, krzyzImage.GetComponent<RectTransform>().anchoredPosition.x);
        krzyzImage.GetComponent<RectTransform>().localScale = new Vector2(allsliders[2].value, allsliders[2].value);
    }

    public void ZmienKolorDodatku(Color c)
    {
        krzyzImage.color = c;
    }

    void UsunComponent()
    {
        Destroy(krzyzImage.transform.gameObject);
        Destroy(this.gameObject);
    }


    public void ZmienDodatek(GameObject dodatekSprite)
    {

        krzyzImage.sprite = dodatekSprite.GetComponent<Image>().sprite;
        btn.GetComponentInChildren<TextMeshProUGUI>().text = dodatekSprite.name;
    }
}
