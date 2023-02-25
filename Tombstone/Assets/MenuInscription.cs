using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuInscription : MonoBehaviour
{
    [SerializeField] InputField[] inputFields;
    [SerializeField] Text[] graveTexts;
    [SerializeField] GameObject graveInscriptionHolder;
    bool isGraveInscrHolderActive = false;
    void Start()
    {
        graveInscriptionHolder.SetActive(isGraveInscrHolderActive);
        //foreach(Text txt in graveTexts)
        //{
        //    txt.text = "";
        //}
    }

    public void UpdateText(int inpIndex)
    {
        graveTexts[inpIndex].text = inputFields[inpIndex].text;
    }

    public void ToggleGraveInscriptionHolder()
    {
        isGraveInscrHolderActive = !isGraveInscrHolderActive;
        graveInscriptionHolder.SetActive(isGraveInscrHolderActive);
    }


    public void InputScroll(int inpIndex)
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            graveTexts[inpIndex].GetComponent<RectTransform>().localScale += Vector3.one * (Input.mouseScrollDelta.y * 0.05f);
        }
        else
        {
            graveTexts[inpIndex].GetComponent<RectTransform>().localPosition += Vector3.up * Input.mouseScrollDelta.y * 0.1f;
        }
    }

    public void MoveInscriptionHolder()
    {
        if (graveInscriptionHolder.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                graveInscriptionHolder.transform.localPosition += Vector3.right * (Input.mouseScrollDelta.y * 0.02f);
            }
            else
            {
                graveInscriptionHolder.transform.localPosition += Vector3.up * (Input.mouseScrollDelta.y * 0.02f);
            }

        }
    }

    public void MoveInscriptionHolderZScale()
    {
        if (graveInscriptionHolder.activeInHierarchy)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                graveInscriptionHolder.transform.localScale += Vector3.one * (Input.mouseScrollDelta.y * 0.04f);
            }
            else
            {
                graveInscriptionHolder.transform.localPosition += Vector3.forward * (Input.mouseScrollDelta.y * 0.04f);
            }

        }
    }

}
