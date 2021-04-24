using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlacement : MonoBehaviour
{ 
    [SerializeField] GameObject gameObjectToPlace;
    ARRaycastManager arRaycastManager;
    static List<ARRaycastHit> hits = new List<ARRaycastHit>();
    public GameObject PlacedGameObject
    {
        get
        {
            return gameObjectToPlace;
        }
        set
        {
            gameObjectToPlace = value;
        }
    }
    void Awake()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }
    bool TryGetTouchPosition (out Vector2 touchPos)
    {
        if (Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0).position;
            return true;
        }
        touchPos = default;
        return false;
    }
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 touchPos))
            return;
        if  (arRaycastManager.Raycast(touchPos,hits,UnityEngine.XR.ARSubsystems.TrackableType.Planes))
        {
            var hitPose = hits[0].pose;
            Instantiate(gameObjectToPlace, hitPose.position, hitPose.rotation);
        }
    }
    
}
