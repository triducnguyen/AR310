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
    public GameObject inCorrectAnswer;
    public GameObject CorrectAnswer;
    public GameObject matchTitle;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            //if(matchTitle != null)
            //    matchTitle.SetActive(false);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            if(eventData.pointerDrag.GetComponent<DragSystem>().CorrectAnswer == Answer)
            {
                eventData.pointerDrag.gameObject.SetActive(false);
                inCorrectAnswer.SetActive(false);
                CorrectAnswer.SetActive(true);
                gameObject.SetActive(false);
            }
            else
            {
                inCorrectAnswer.SetActive(true);
                CorrectAnswer.SetActive(false);
            }
        }

    }



}
