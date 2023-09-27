using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotor : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        float swing = gameObject.transform.rotation.y;
        if (swing == -45f)
        {
            transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
        if (swing == 45f)
        {
            transform.Rotate(new Vector3(0, -10, 0) * Time.deltaTime);
        }
        if ((swing != 45f) || (swing != -45f))
        {
            transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
    }
}
