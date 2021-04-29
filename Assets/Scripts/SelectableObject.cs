using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectableObject : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject objectText;
    bool selected = false;
    public void ToggleSelected()
    {
        selected = !selected;

        objectText.SetActive(selected);
    }
}
