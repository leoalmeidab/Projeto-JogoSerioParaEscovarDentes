using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Parabens : MonoBehaviour, IDropHandler
{
    public GameObject text;

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            GameObject passo1 = GameObject.Find("passo1");
            GameObject passo2 = GameObject.Find("passo2");
            GameObject passo3 = GameObject.Find("passo3");
            GameObject passo4 = GameObject.Find("passo4");
            GameObject passo5 = GameObject.Find("passo5");
            GameObject passo6 = GameObject.Find("passo6");

            if(passo1.GetComponent<RectTransform>().anchoredPosition != new Vector2(451f, -174f) &&
            passo2.GetComponent<RectTransform>().anchoredPosition != new Vector2(300f, -174f) &&
            passo3.GetComponent<RectTransform>().anchoredPosition != new Vector2(130f, -174f) &&
            passo4.GetComponent<RectTransform>().anchoredPosition != new Vector2(-35f, -174f) &&
            passo5.GetComponent<RectTransform>().anchoredPosition != new Vector2(-218f, -174f) &&
            passo6.GetComponent<RectTransform>().anchoredPosition != new Vector2(-405f, -174f)) 
            {
                Debug.Log("SHOW");
                 text.SetActive(false);
            } else {
                Debug.Log("HIDE");
                text.SetActive(false);
            }
        }
    }
}
