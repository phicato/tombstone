using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemMesh : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponentInParent<MenuItem>().EnableGraveItem();
    }
}
