using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject objectToSetActive;
    public bool selected = false;
    public void ToggleSelected()
    {
        selected = !selected;

        objectToSetActive.SetActive(selected);
    }

    private void Update()
    {
            objectToSetActive.SetActive(selected);
    }
}
