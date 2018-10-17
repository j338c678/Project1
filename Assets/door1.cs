using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{


    public int LevelToLoad;

    //private player p;

    //void Start()
    //{
    //p=GameObject.FindGameObjectsWithTag("")
    //}

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //if (Input.GetKeyDown("e"))
            //{
                Application.LoadLevel(LevelToLoad);
            //}
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }


}