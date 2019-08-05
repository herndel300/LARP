using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float speed = 0.25f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }
    // Update is called once per frame
    void Update () {

        float newPos = Mathf.Repeat(Time.time * speed, 20);
        transform.position = startPos + Vector2.left * newPos;

	}
}
