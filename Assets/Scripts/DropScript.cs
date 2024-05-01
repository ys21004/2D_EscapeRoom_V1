using UnityEngine;
using UnityEngine.EventSystems;

public class DropScript : MonoBehaviour, IDropHandler
{
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
            GetComponent<RectTransform>().anchoredPosition;
    }
}

