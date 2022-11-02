using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePositionOffset;

    private Vector3 GetMouseWorldPosition()
    {
        Debug.Log("GetMouseWorldPosition");
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void onMouseDown()
    {
        Debug.Log("onMouseDown");
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        Debug.Log("OnMouseDrag");
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
}
