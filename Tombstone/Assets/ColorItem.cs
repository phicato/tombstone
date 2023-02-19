using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorItem : MonoBehaviour
{
    Grave grave;
    void Start()
    {
        grave = FindObjectOfType<Grave>();
    }

    private void OnMouseDown()
    {
        Material pickedMaterial = GetComponent<MeshRenderer>().material;
        if (grave.activeElement != null)
        {
            grave.activeElement.GetComponent<MeshRenderer>().material = pickedMaterial;
        }
    }
}
