using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Background : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDropBackGround");
        if (eventData.pointerDrag != null) {
            if(eventData.pointerDrag.name ==  "passo1") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(451f, -174f);
            }
            else if(eventData.pointerDrag.name ==  "passo2") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(300f, -174f);
            }
            else if(eventData.pointerDrag.name ==  "passo3") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(130f, -174f);
            }
            else if(eventData.pointerDrag.name ==  "passo4") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(-35f, -174f);
            }
            else if(eventData.pointerDrag.name ==  "passo5") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(-218f, -174f);
            }
            else if(eventData.pointerDrag.name ==  "passo6") {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = new Vector2(-405f, -174f);
            }
        }
    }
}
