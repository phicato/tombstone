using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GItem : MonoBehaviour
{
    Camera cam;
    Grave grave;
    Vector2 offset;

    void Start()
    {
        cam = Camera.main;
        grave = GetComponentInParent<Grave>();
    }

    private void OnMouseDown()
    {
        grave.activeElement = gameObject;
        if (Input.GetKey(KeyCode.LeftControl))
        {
            offset = cam.ScreenToWorldPoint(Input.mousePosition) - transform.localPosition;
        }
        else
        {
            offset = cam.ScreenToWorldPoint(Input.mousePosition) - grave.transform.position;
        }

    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButton(1))
        {
            float speed = 800f;
            grave.transform.rotation *= Quaternion.Euler(0f, Input.GetAxis("Mouse X") * -speed * Time.deltaTime, 0f);
            grave.transform.GetChild(0).transform.rotation *= Quaternion.Euler(Input.GetAxis("Mouse Y") * speed * Time.deltaTime, 0f,  0f);
        }

        grave.transform.localScale += Vector3.one * Input.mouseScrollDelta.y * 0.1f;
    }

    private void OnMouseDrag()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            
            transform.localPosition = new Vector3( cam.ScreenToWorldPoint(Input.mousePosition).x - offset.x, 0f, cam.ScreenToWorldPoint(Input.mousePosition).y - offset.y);
        }
        else
        {
            grave.transform.localPosition = cam.ScreenToWorldPoint(Input.mousePosition) - (Vector3)offset;

        }
    }

}
