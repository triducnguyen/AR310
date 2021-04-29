using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggingManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string draggableTag;
    public Camera cam;

    Vector3 dis;
    float posX;
    float posY;

    bool touching = false;

    Transform toDrag;

    Rigidbody toDragRigidBody;

    Vector3 previousPos;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.touchCount != 1)
        {
            touching = false;
            return;
        }
        Touch touch = Input.touches[0];
        Vector3 pos = touch.position;
        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out hit) && hit.collider.tag == draggableTag)
            {
                touching = true;
                toDrag = hit.transform;
                previousPos = toDrag.position;
                toDragRigidBody = toDrag.GetComponent<Rigidbody>();

                dis = cam.WorldToScreenPoint(previousPos);
                posX = Input.GetTouch(0).position.x - dis.x;
                posY = Input.GetTouch(0).position.x - dis.y;
            }
        }
        if (touch.phase == TouchPhase.Moved)
        {
            touching = true;
            float newPosX = Input.GetTouch(0).position.x - posX;
            float newPosY = Input.GetTouch(0).position.x - posY;
            Vector3 curPos = new Vector3(newPosX, newPosY, dis.z);

            Vector3 worldPos = cam.ScreenToWorldPoint(curPos) - previousPos;
            worldPos = new Vector3(worldPos.x, worldPos.y, 0.0f);

            toDragRigidBody.velocity = worldPos / Time.deltaTime;

            previousPos = toDrag.position;
            SetDraggingProperties(toDragRigidBody);
        }
        if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
        {
            touching = false;

            previousPos = new Vector3(0f, 0f, 0f);

            SetFreeProperties(toDragRigidBody);
        }

    }
    void SetDraggingProperties(Rigidbody rb)
    {
        rb.useGravity = false;
        rb.drag = 5;
    }
    void SetFreeProperties(Rigidbody rb)
    {
        rb.useGravity = true;
        rb.drag = 2;
    }
}