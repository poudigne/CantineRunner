using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public float speed = -5.0f;

    void Update()
    {
        transform.Translate(new Vector3(speed * Time.deltaTime, 0.0f, 0.0f));
    }

}
