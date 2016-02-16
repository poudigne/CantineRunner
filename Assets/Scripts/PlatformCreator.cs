using UnityEngine;
using System.Collections;

public class PlatformCreator : MonoBehaviour {

    public bool hasPlatformInside = false;

    public GameObject platformPrefab = null;
    public Transform platformContainer;


    void OnTriggerEnter2D(Collider2D collidedObject)
    {
        switch (collidedObject.tag)
        {
            case "Platform":
                hasPlatformInside = true;
                break;
        }
    }

    void OnTriggerExit2D(Collider2D collidedObject)
    {
        switch (collidedObject.tag)
        {
            case "Platform":
                hasPlatformInside = false;
                break;
        }
    }
    void Update()
    {
        if (!hasPlatformInside)
            SpawnPlatform();
    }


    void SpawnPlatform()
    {
        GameObject platformObject = Instantiate(platformPrefab, transform.position, Quaternion.identity) as GameObject;
        platformObject.transform.parent = platformContainer;
    }
}
