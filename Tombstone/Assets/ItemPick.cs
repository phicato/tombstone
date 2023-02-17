using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPick : MonoBehaviour
{
    string itemName;
    private void Start()
    {
        itemName = name;
        transform.eulerAngles = new Vector3(50f, 0f, 0f);
    }

    private void OnMouseDown()
    {
        if(itemName[2..] == "top")
        {
            GAppManager.Instance.SetTop(int.Parse(name[..2]));

        }
    }
}
