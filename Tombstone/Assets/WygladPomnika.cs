using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WygladPomnika : MonoBehaviour
{
    Camera cam;
    [SerializeField] Slider rotacjaSlider;
    [SerializeField] Slider zoomSlider;
    void Start()
    {
        cam = Camera.main;
    }

    public void ObrocPomnik()
    {
        transform.eulerAngles = new Vector3(0f, rotacjaSlider.value, 0f);
    }

    public void ZoomKamery()
    {
        cam.fieldOfView = zoomSlider.value;
        
    }
}
