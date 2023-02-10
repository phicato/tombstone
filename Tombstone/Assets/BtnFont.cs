using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
public class BtnFont : MonoBehaviour
{
    public TextMeshProUGUI tekst1;
    public TextMeshProUGUI tekst2;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => ColorText());
    }

    void ColorText()
    {
        tekst1.font = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().font;
        tekst2.font = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<TMP_Text>().font;

    }
}
