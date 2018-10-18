using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question2 : MonoBehaviour
{
    List<string> questions = new List<string>() { "A Semicolon (;)", "A Fullstop(.)", "A Comma (,)", "A Slash (/)" };
    public Dropdown dropdown;

    // Use this for initialization
    void Start()
    {
        questionlist();
    }

    // Update is called once per frame
    //A Semicolon (;)
    void questionlist()
    {
        dropdown.AddOptions(questions);
    }
}
