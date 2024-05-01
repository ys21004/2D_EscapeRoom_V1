using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragScript : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    RectTransform rec;

    Image img;

    Color tempColor;

    [SerializeField]Canvas canvas;
    
    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        tempColor = img.color;
        tempColor.a = 0.5f;
        img.color = tempColor;
    }
    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        rec.anchoredPosition += eventData.delta/canvas.scaleFactor;
        img.raycastTarget = false;
    }

   

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
       tempColor = img.color;
       tempColor.a = 1f;
       img.color = tempColor; 
       img.raycastTarget = true;

    }

    void Awake()
    {
        rec = GetComponent<RectTransform>();
        img = GetComponent<Image>();
    }
}
