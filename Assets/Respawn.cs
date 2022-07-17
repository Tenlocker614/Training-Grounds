using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject gameobject;

    void Update()
    {
        if(gameobject.transform.position.y < 10)
        {
            gameobject.transform.position = new Vector3(-573, 26, -3);
        }
    }
}
