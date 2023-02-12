using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Fotografie : MonoBehaviour
{
    [SerializeField] Image fotografia;
    [SerializeField] RectTransform fotografiaGrupa;
    [SerializeField] Slider[] slidery;
    [SerializeField] GameObject fotografiePrzyciski;
    [SerializeField] GameObject koloryPrzyciski;
    Button[] btnFotografie;
    Button[] btnKolory;
    void Start()
    {
        btnFotografie = fotografiePrzyciski.GetComponentsInChildren<Button>();
        btnKolory = koloryPrzyciski.GetComponentsInChildren<Button>();
        foreach (var btn in btnKolory)
        {
            btn.GetComponent<Button>().onClick.AddListener(() => WybierzKolor());
        }
        foreach (var btn in btnFotografie)
        {
            btn.GetComponent<Button>().onClick.AddListener(() => WybierzKrzyz());
        }
    }

    public void UstawPozycje()
    {
        fotografiaGrupa.anchoredPosition = new Vector2(slidery[0].value, fotografiaGrupa.anchoredPosition.y);
        fotografiaGrupa.anchoredPosition = new Vector2(slidery[1].value, fotografiaGrupa.anchoredPosition.x);
        fotografiaGrupa.localScale = new Vector2(slidery[2].value, slidery[2].value);
    }

    public void WybierzKrzyz()
    {
        fotografia.sprite = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;
    }

    void WybierzKolor()
    {
        fotografia.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
    }
}
