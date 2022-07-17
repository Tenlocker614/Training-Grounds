using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stick_to_platform : MonoBehaviour
{
    private Vector3 velocity;
    private bool moving;
    public GameObject platform;

    void start()
    {
        moving = true;
        platform.transform.SetParent(transform);
    }

    void update()
    {
        moving = true;
        platform.transform.SetParent(transform);
    }
 
}
