using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reach_checkpoint : MonoBehaviour
{
    public GameObject[] targets;
    
    public void OnCollisionEnter(Collision collision)
    {
        

        if (collision.collider.name == "Player")
        {
            if (targets==null)
            {
                SceneManager.LoadScene("main menu");
            }
            
        }
    }
}
