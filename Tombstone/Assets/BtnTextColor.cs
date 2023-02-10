using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class BtnTextColor : MonoBehaviour
{
    NapisComponent napisComponent;
    void Start()
    {
        napisComponent = this.GetComponentInParent<NapisComponent>();
        this.GetComponent<Button>().onClick.AddListener(() => ColorText());
    }

    void ColorText()
    {
        napisComponent.ChangeTextColor();

    }
}
