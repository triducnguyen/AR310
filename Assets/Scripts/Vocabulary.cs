using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vocabulary : MonoBehaviour
{
    public List<GameObject> facts;
    public GameObject button;
    private int counter;
    private int totalFacts;
    // Start is called before the first frame update
    private void Awake()
    {
        counter = 0;
        facts[counter].SetActive(true);
        facts[counter + 1].SetActive(false);
        facts[counter + 2].SetActive(false);
        facts[counter + 3].SetActive(false);

    }
    void Start()
    {
        counter = 0;
        totalFacts = 4;
    }

    // Update is called once per frame


    public void Increament()
    {

        counter++;
        if(counter > 3)
        {
            counter = 0;
        }
        if (counter == 0)
        {
            facts[0].SetActive(true);
            facts[1].SetActive(false);
            facts[2].SetActive(false);
            facts[3].SetActive(false);
        }
        else if (counter == 1)
        {
            facts[1].SetActive(true);
            facts[0].SetActive(false);
            facts[2].SetActive(false);
            facts[3].SetActive(false);


        }
        else if (counter == 2)
        {
            facts[2].SetActive(true);
            facts[1].SetActive(false);
            facts[0].SetActive(false);
            facts[3].SetActive(false);

        }
        else if (counter == 3)
        {
            facts[3].SetActive(true);
            facts[2].SetActive(false);
            facts[1].SetActive(false);
            facts[0].SetActive(false);
            button.SetActive(true);
        }
    }
    public void Decreament()
    {

        counter--;
        Debug.Log(counter);
        if (counter < 0)
        {
            counter = 3;
        }
        if (counter == 0)
        {
            facts[0].SetActive(true);
            facts[1].SetActive(false);
            facts[2].SetActive(false);
            facts[3].SetActive(false);

            Debug.Log(counter);
        }
        else if (counter == 1)
        {
            facts[1].SetActive(true);
            facts[0].SetActive(false);
            facts[2].SetActive(false);
            facts[3].SetActive(false);

        }
        else if (counter == 2)
        {
            facts[2].SetActive(true);
            facts[1].SetActive(false);
            facts[0].SetActive(false);
            facts[3].SetActive(false);
        }
        else if (counter == 3)
        {
            facts[3].SetActive(true);
            facts[2].SetActive(false);
            facts[1].SetActive(false);
            facts[0].SetActive(false);
        }
    }
}
