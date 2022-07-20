using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PattenSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Ondrop");
        if(eventData.pointerDrag != null)
        {
            Debug.Log(GetComponent<RectTransform>().anchoredPosition);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().localPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().sizeDelta = GetComponent<RectTransform>().sizeDelta * 0.85f;
        }
    }
}
