using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pomnik : MonoBehaviour
{
    GameObject nakrywa1;
    GameObject nakrywa2;
    GameObject scianka1;
    GameObject scianka2;
    GameObject scianka3;
    GameObject kraweznik1;
    GameObject kraweznik2;
    GameObject okladzina;

    void Start()
    {
        nakrywa1 = transform.Find("nakrywa1").gameObject;
        Debug.Log(nakrywa1.transform.position);
    }


    void Update()
    {
        
    }
}
