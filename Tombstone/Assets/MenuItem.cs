using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItem : MonoBehaviour
{

    private void OnMouseDown()
    {
        if(transform.childCount == 0)
        {
            EnableGraveItem();
        }
        
    }


    public void EnableGraveItem()
    {
        string itemCategory = gameObject.name[2..3];
        int index = int.Parse(gameObject.name[0..2]);
        Menu.Instance.EnableGraveItem(itemCategory, index);
    }
}
