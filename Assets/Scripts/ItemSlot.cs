using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        print("OnDrop");
        if (eventData.pointerDrag!=null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = 
                GetComponent<RectTransform>().anchoredPosition;
        }
    }

    
}
