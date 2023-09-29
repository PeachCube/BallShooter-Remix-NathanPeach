using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverZAxis : MonoBehaviour
{
    static float minz;
    static float maxz;
    void Start()
    {
        minz = gameObject.transform.position.z - 5;
        maxz = gameObject.transform.position.z + 5;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, maxz - minz) + minz);
    }
}
