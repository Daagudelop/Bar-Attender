using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ToOPAfterdrop : MonoBehaviour,IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{


    private RectTransform _rectTransform;

    private Vector2 initialTransform;

    private void Awake()
    {
        _rectTransform = GetComponent<RectTransform>();
        //_rectTransform.localPosition = Vector3.zero;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        initialTransform = _rectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
        _rectTransform.anchoredPosition = initialTransform;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

}
