using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class KrzyzePiaskowane : MonoBehaviour
{
    [SerializeField] Image krzyz;
    [SerializeField] Slider[] slidery;
    [SerializeField] GameObject krzyzePiaskowanePrzyciski;
    [SerializeField] GameObject koloryPrzyciski;
    Button[] btnKrzyze;
    Button[] btnKolory;
    void Start()
    {
        btnKrzyze = krzyzePiaskowanePrzyciski.GetComponentsInChildren<Button>();
        btnKolory = koloryPrzyciski.GetComponentsInChildren<Button>();
        foreach (var btn in btnKolory)
        {
            btn.GetComponent<Button>().onClick.AddListener(() => WybierzKolor());
        }
        foreach (var btn in btnKrzyze)
        {
            btn.GetComponent<Button>().onClick.AddListener(() => WybierzKrzyz());
        }
    }

    public void UstawPozycje()
    {
        krzyz.GetComponent<RectTransform>().anchoredPosition = new Vector2(slidery[0].value, krzyz.GetComponent<RectTransform>().anchoredPosition.y);
        krzyz.GetComponent<RectTransform>().anchoredPosition = new Vector2(slidery[1].value, krzyz.GetComponent<RectTransform>().anchoredPosition.x);
        krzyz.GetComponent<RectTransform>().localScale = new Vector2(slidery[2].value, slidery[2].value);
    }

    public void WybierzKrzyz()
    {
        krzyz.sprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;
    }

    void WybierzKolor()
    {
        krzyz.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }
}
