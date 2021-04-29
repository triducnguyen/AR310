using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchableObject : MonoBehaviour
{
    public int type;
   // public bool beingTouched;
    Vector3 startingPos;
    private void Start()
    {
        startingPos = gameObject.transform.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MatchableObject>() != null)
        {
            var collidedObjectType = collision.gameObject.GetComponent<MatchableObject>().type;
            var collidedObject = collision.gameObject.GetComponent<MatchableObject>();

            if (collidedObjectType == type)
            {
                Destroy(gameObject);
                Destroy(collidedObject);
            }
            else
            {
                gameObject.transform.position = startingPos;
            }
        }
    }
}
