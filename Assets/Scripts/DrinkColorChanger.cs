using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrinkColorChanger : MonoBehaviour, IDropHandler
{

    public GameObject[] colorparts;
    private void Awake()
    {
        colorparts = GameObject.FindGameObjectsWithTag("ColorChanger");
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            foreach (GameObject item in colorparts)
            {
                Color color = item.GetComponent<SpriteRenderer>().color;
                item.GetComponent<SpriteRenderer>().color = Color.Lerp(color, 
                    eventData.pointerDrag.GetComponent<Image>().color, 0.5f);

                color = item.GetComponent<SpriteRenderer>().color;
                color.a = 1f;
                item.GetComponent<SpriteRenderer>().color = color;
            }
        }
    }

    
}
