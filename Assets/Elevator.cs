using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private float startpos;
    void Start()
    {
        startpos = transform.position.y;
    }

    void Update()
    {
        
        if (startpos != Vector3.up.y*5)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 0.5f);
        }
    }
}
