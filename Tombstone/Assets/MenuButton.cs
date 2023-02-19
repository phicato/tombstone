using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    Button btn;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => Menu.Instance.TogglePanel(int.Parse(btn.gameObject.name.Substring(0, 1))));
    }

}
