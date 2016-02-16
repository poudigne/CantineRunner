using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
    public float destroyAfterX = -25.0f;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < destroyAfterX)
            Destroy(gameObject);
	}
}
