using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class BtnDodatekKrzyz : MonoBehaviour
{
    public DodatekComponent dodatekComponent;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => ZmienDodatek());
    }

    void ZmienDodatek()
    {
        dodatekComponent.ZmienDodatek(EventSystem.current.currentSelectedGameObject); 
    }
}
