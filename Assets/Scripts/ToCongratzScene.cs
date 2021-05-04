using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToCongratzScene : MonoBehaviour
{
    public List<GameObject> list;
    public bool isComplete;

    // Start is called before the first frame update
    void Start()
    {
        isComplete = false;
        StartCoroutine(CheckIfAllInActive());
    }

    private IEnumerator CheckIfAllInActive()
    {
        yield return null;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
