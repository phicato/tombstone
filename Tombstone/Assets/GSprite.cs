using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSprite : MonoBehaviour
{
    Camera cam;
    Vector2 offset;

    void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
         offset = cam.ScreenToWorldPoint(Input.mousePosition) - transform.localPosition;
    }

    private void OnMouseOver()
    {
        transform.localScale += Vector3.one * Input.mouseScrollDelta.y * 0.1f;
    }

    private void OnMouseDrag()
    {
         transform.localPosition = new Vector3(cam.ScreenToWorldPoint(Input.mousePosition).x - offset.x, cam.ScreenToWorldPoint(Input.mousePosition).y - offset.y, 0f);
    }
}
