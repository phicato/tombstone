using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BtnDodatekColor : MonoBehaviour
{
    public DodatekComponent dodatekComponent;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => ZmienDodatek());
    }

    void ZmienDodatek()
    {
        dodatekComponent.ZmienKolorDodatku(EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color);
    }
}
