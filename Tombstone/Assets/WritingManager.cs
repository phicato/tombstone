using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class WritingManager : MonoBehaviour
{
    public TextMeshProUGUI tekst1;
    public TextMeshProUGUI tekst2;
    public Slider[] allsliders;

    void Start()
    {
        
    }

    public void SetSliders()
    {
        tekst1.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[0].value, tekst1.GetComponent<RectTransform>().anchoredPosition.y);
        tekst1.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[1].value, tekst1.GetComponent<RectTransform>().anchoredPosition.x);
        tekst1.fontSize = allsliders[2].value;
        tekst2.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[3].value, tekst2.GetComponent<RectTransform>().anchoredPosition.y);
        tekst2.GetComponent<RectTransform>().anchoredPosition = new Vector2(allsliders[4].value, tekst2.GetComponent<RectTransform>().anchoredPosition.x);
        tekst2.fontSize = allsliders[5].value;
    }

    public void ChangeTextColor(Color col)
    {
        tekst1.GetComponent<Image>().color = col;
        tekst2.GetComponent<Image>().color = col;
    }


}
