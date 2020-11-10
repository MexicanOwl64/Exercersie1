using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{

    void Start()
    {

    }

    void FixedUpdate()
    {
        float x = Random.Range(Random.Range(0, 10), Random.Range(0, 10));

        float y = Random.Range(Random.Range(0, 10), Random.Range(0, 10)); ;

        transform.position = new Vector3(x, y, 0);

    }
}
