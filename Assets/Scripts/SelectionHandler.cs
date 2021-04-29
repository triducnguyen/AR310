using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class SelectionHandler : MonoBehaviour
{
    [SerializeField] Camera sceneCamera;
    Vector2 touchPosition = default;
    ARRaycastManager arRaycastManager;

    // Start is called before the first frame update
    void Start()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = touch.position;

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = sceneCamera.ScreenPointToRay(touchPosition);
                RaycastHit hitObject;
                if (Physics.Raycast(ray, out hitObject))
                {
                    if (hitObject.transform.tag == "SelectableObject" && hitObject.transform.GetComponent<SelectableObject>() != null)
                    {
                        hitObject.transform.GetComponent<SelectableObject>().ToggleSelected();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
