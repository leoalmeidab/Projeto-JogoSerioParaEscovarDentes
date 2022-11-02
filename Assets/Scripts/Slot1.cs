using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot1 : MonoBehaviour, IDropHandler
{
    public GameObject text, button;
    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            if(eventData.pointerDrag.name ==  "passo1") {
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                if(GameObject.Find("passo1").GetComponent<RectTransform>().anchoredPosition != new Vector2(451f, -174f) 
                    && GameObject.Find("passo2").GetComponent<RectTransform>().anchoredPosition != new Vector2(300f, -174f)
                    && GameObject.Find("passo3").GetComponent<RectTransform>().anchoredPosition != new Vector2(130f, -174f)
                    && GameObject.Find("passo4").GetComponent<RectTransform>().anchoredPosition != new Vector2(-35f, -174f)
                    && GameObject.Find("passo5").GetComponent<RectTransform>().anchoredPosition != new Vector2(-218f, -174f)
                    && GameObject.Find("passo6").GetComponent<RectTransform>().anchoredPosition != new Vector2(-405f, -174f)) {

                    GameObject.Find("fundo banheiro").GetComponent<AudioSource>().Play();
                    text.SetActive(true);
                    button.SetActive(true);
                } else {
                    GetComponent<AudioSource>().Play();
                }
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
