using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector3 mOffset;
    float mZcord;

    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        mZcord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWordlPos();
    }
    Vector3 GetMouseWordlPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZcord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWordlPos() + mOffset;
    }
}
