using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Writing : MonoBehaviour
{
    public TextMeshProUGUI writing;
    public TMP_InputField inpWriting;

    void Start()
    {

    }

    public void ChangeText()
    {
        writing.text = inpWriting.GetComponent<TMP_InputField>().text;
    }





}
