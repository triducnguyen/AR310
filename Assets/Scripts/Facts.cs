using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Facts : MonoBehaviour
{
    public List<TMP_Text> facts;
    public TMP_Text presentText;
    public GameObject button;
    private int counter;
    private int totalFacts;
    // Start is called before the first frame update
    private void Awake()
    {
        counter = 0;
        presentText.text = facts[counter].text;
    }
    void Start()
    {
        counter = 0;
        totalFacts = 11;
    }

    // Update is called once per frame

    public void Increament()
    {

     if (counter >= 0 && counter < totalFacts)
        {
            counter++;
            presentText.text = facts[counter].text;
        }     
     if(counter == 10)
        {
            presentText.text = facts[counter].text;
            button.SetActive(true);
            counter = 0;
        }
        Debug.Log(counter);
    }
    public void Decreament()
    {
        if (counter == 0)
        {
            counter = 10;
            presentText.text = facts[counter].text;

        }
        else if (counter > 0 && counter < totalFacts)
        {
            counter--;
            presentText.text = facts[counter].text;

        }
        Debug.Log(counter);
    }


}
