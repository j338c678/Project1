using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question4 : MonoBehaviour
{
    List<string> questions = new List<string>() { "thrown", "threw", "throw", "throws" };
    public Dropdown dropdown;

    // Use this for initialization
    void Start()
    {
        questionlist();
    }

    // Update is called once per frame
    //throw
    void questionlist()
    {
        dropdown.AddOptions(questions);
    }
}
