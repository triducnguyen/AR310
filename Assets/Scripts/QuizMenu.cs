using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizMenu : MonoBehaviour
{
    public List<GameObject> Quiz;
    public GameObject button;
    public GameObject dancingShark;
    public GameObject background;
    private int counter;
    // Start is called before the first frame update
    private void Awake()
    {
        counter = 0;
        Quiz[0].SetActive(true);
        Quiz[1].SetActive(false);
        Quiz[2].SetActive(false);
    }

    public void CorrectAnswer()
    {
        counter++;
        if(counter == 3)
        {
            Quiz[counter - 1].SetActive(false);
            button.SetActive(false);
            dancingShark.SetActive(true);
            background.SetActive(true);
            return;
            
        }
        Quiz[counter - 1 ].SetActive(false);
        Quiz[counter].SetActive(true);
    }
    public void InCorrectAnswer()
    {
        Debug.Log("Incorrect Answer");
    }
}
