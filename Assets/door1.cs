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

    public bool indoor = false;
    void OnTriggerStay2D(Collider2D collision)
    {
        if (indoor == false)
        {
            if (collision.CompareTag("Player"))
            {
                if (Input.GetKeyDown("e"))
                {
                    Application.LoadLevel(LevelToLoad);
                    indoor = true;
                }

            }
        }
    }   

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }


}