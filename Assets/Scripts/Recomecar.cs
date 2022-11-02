using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recomecar : MonoBehaviour
{
    public GameObject text, button;
    public void recomeca()
    {
        GameObject.Find("passo1").GetComponent<RectTransform>().anchoredPosition = new Vector2(451f, -174f);
        GameObject.Find("passo2").GetComponent<RectTransform>().anchoredPosition = new Vector2(300f, -174f);
        GameObject.Find("passo3").GetComponent<RectTransform>().anchoredPosition = new Vector2(130f, -174f);
        GameObject.Find("passo4").GetComponent<RectTransform>().anchoredPosition = new Vector2(-35f, -174f);
        GameObject.Find("passo5").GetComponent<RectTransform>().anchoredPosition = new Vector2(-218f, -174f);
        GameObject.Find("passo6").GetComponent<RectTransform>().anchoredPosition = new Vector2(-405f, -174f);

        text.SetActive(false);
        button.SetActive(false);
    }

}
