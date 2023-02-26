using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MenuWallDecoration : MonoBehaviour
{
    [SerializeField] Sprite[] wallDecorations;
    [SerializeField] Transform btnPanel;
    [SerializeField] GameObject btnMenuPrefab;
    [SerializeField] Transform graveDecorationHolder;


    void Start()
    {
        CreatePanelButtons();
    }

    public void CreatePanelButtons()
    {
        for(int i = 0; i < wallDecorations.Length; i++)
        {
            GameObject btn = Instantiate(btnMenuPrefab, btnPanel);
            btn.GetComponent<Image>().sprite = wallDecorations[i];
            btn.GetComponentInChildren<Text>().text = wallDecorations[i].name;
            btn.GetComponent<Button>().onClick.AddListener(() => PickWallDecoration());
        }
    }

    public void PickWallDecoration()
    {
        Sprite sp = EventSystem.current.currentSelectedGameObject.GetComponent<Image>().sprite;
        graveDecorationHolder.GetComponentInChildren<SpriteRenderer>().sprite = sp;
    }

    public void ChangeColor(Color col)
    {
        graveDecorationHolder.GetComponentInChildren<SpriteRenderer>().color = col;
    }




}
