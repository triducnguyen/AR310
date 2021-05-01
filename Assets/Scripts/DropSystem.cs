using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DropSystem : MonoBehaviour, IDropHandler
{
    private float elapsedTime = 0f;
    private bool timer;
    public int Answer;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(eventData.pointerDrag.GetComponent<DragSystem>().CorrectAnswer == Answer)
            {
                eventData.pointerDrag.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }

    }



}
