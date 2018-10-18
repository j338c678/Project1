using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class points : MonoBehaviour
{

    public int score;
    public Text point;



    // Update is called once per frame
    void Update()
    {
        point.text = (" " + score);
    }
}