using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class BtnTextColor : MonoBehaviour
{
    public TextMeshProUGUI tekst1;
    public TextMeshProUGUI tekst2;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => ColorText());
    }

    void ColorText()
    {
        tekst1.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;
        tekst2.color = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color;

    }
}
