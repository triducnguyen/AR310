using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCongratzScene : MonoBehaviour
{
    public List<GameObject> list;
    public GameObject CongratzScene;
    public bool isComplete;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        isComplete = false;
        StartCoroutine(CheckIfAllInActive());
    }

    private IEnumerator CheckIfAllInActive()
    {
        while (count <= 3)
        {
            foreach (GameObject obj in list)
            {
                if (obj.GetComponent<DropSystem>().CheckifInactive == 1)
                {
                    count++;
                    obj.GetComponent<DropSystem>().CheckifInactive = 0;
                }

            }
            if (count == 3)
            {
                CongratzScene.SetActive(true);
                gameObject.SetActive(false);
            }
            Debug.Log(count);
            yield return null;
        }
    }

}

