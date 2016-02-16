using UnityEngine;
using System.Collections;

public class PlatformCreator : MonoBehaviour {

    public bool hasPlatformInside = false;

    public float maxHeight = 2.5f;

    public GameObject platformPrefab = null;
    public Transform platformContainer;
    private Vector3 lastPos;
    void Start()
    {
        InvokeRepeating("SpawnPlatform", 0, 1F);
    }
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
    //void FixedUpdate()
    //{
    //    if (Time.time > nextActionTime)
    //    {
    //        nextActionTime += period;
    //        if (!hasPlatformInside)
    //            SpawnPlatform();
    //    }
    //}


    void SpawnPlatform()
    {
        var upOrDown = Random.Range(-1, 1);
        if (upOrDown >= 0.0f)
            upOrDown = 1;
        else
            upOrDown = -1;
        Debug.Log("upordown = " + upOrDown);
        var offset = Random.Range(0.0f, maxHeight);
        var newPos = new Vector3(transform.position.x, lastPos.y + (offset * upOrDown) , 0.0f);
        GameObject platformObject = Instantiate(platformPrefab, newPos, Quaternion.identity) as GameObject;
        lastPos = newPos;
        platformObject.transform.parent = platformContainer;
        Debug.Log(lastPos);
    }
}
