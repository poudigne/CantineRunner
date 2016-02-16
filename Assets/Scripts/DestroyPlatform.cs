using UnityEngine;
using System.Collections;

public class DestroyPlatform : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collidedObject)
    {
        Debug.Log("destroyer tag : " + collidedObject.tag);
        switch (collidedObject.tag)
        {
            case "Platform":
                Destroy(collidedObject.gameObject);
                break;
        }
    }
}
