using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    static float minx;
    static float maxx;
    void Start()
    {
        minx = gameObject.transform.position.x-5;
        maxx = gameObject.transform.position.x+5;
    }
    void Update()
    {
        //"Borrowed" from stack overflow, but I can vaguely explain how it works.
        //Every frame, the gameOject's position is set to the new Vector3.
        //The new Vector3 consists of x, y, and z coordinates (obviously). 
        //transform.position.y and transform.position.z never change, but the x position does.
        //Mathf is a library of math functions for Unity, and .PingPong is a method that returns a value based on two input variables.
        //the first input variable is Time, and the second value, seperated by a comma inside the parentheses, is the length between each end of the chosen axis.
        // + minx is added after the parentheses so the gameObject stays within the max and min when it loads in (based on in-game observation)
        //I thought that it was because PingPong just returns a fluctuating value based on its parameters but if that worked then I don't understand why -
        //it needs to know where the gameObject's original position is, since minx is being added afterwards.
        gameObject.transform.position = new Vector3(Mathf.PingPong(Time.time * 2.5f, maxx - minx) + minx, transform.position.y, transform.position.z);
    }
}

