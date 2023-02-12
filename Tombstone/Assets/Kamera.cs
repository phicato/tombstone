using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Camera mainCamera;
    Vector3 pozycjaBazowa = new Vector3(1.08f, 0.6f, -2f);
    Vector3 rotacjaBazowa = new Vector3(17.8f, -46f, -5.4f);


    void Start()
    {
        mainCamera = Camera.main;
    }

    public void UstawKamereDoBazy()
    {
        mainCamera.transform.position = pozycjaBazowa;
        mainCamera.transform.localEulerAngles = rotacjaBazowa;
        mainCamera.depth = 2;
    }
}
