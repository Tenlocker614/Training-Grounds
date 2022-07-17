using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_killed : MonoBehaviour
{
    public float enemies_kill = 0f;

   public void update()
    {
        enemies_kill += 1;
    }
}
