using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastRotor : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }
}
